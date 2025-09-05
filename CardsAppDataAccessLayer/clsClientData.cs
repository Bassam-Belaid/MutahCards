using System;
using System.Data;

using MySql.Data.MySqlClient;


namespace CardsAppDataAccessLayer
{
    public class clsClientData
    {

        public static bool FindClient(ref int ClientID, string Username, ref string Password, ref decimal Balance) 
        {

            bool IsFound = false;

            MySqlConnection Connection = new MySqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT ClientID, Password, Balance
                             From Clients
                             WHERE Username = @Username;";

            MySqlCommand Command = new MySqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@Username", Username);

            try
            {

                Connection.Open();

                MySqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    ClientID = (int)Reader["ClientID"];
                    Password = (string)Reader["Password"];
                    Balance = (decimal)Reader["Balance"];

                    IsFound = true;

                }

            }

            catch (Exception ex)
            {

                IsFound = false;

            }

            finally
            {

                Connection.Close();

            }

            return IsFound;

        }

        public static bool CheckClientBalance(int ClientID, decimal Value)
        {

            bool IsEnough = false;

            MySqlConnection Connection = new MySqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT Balance FROM Clients WHERE ClientID = @ClientID;";

            MySqlCommand Command = new MySqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {

                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && decimal.TryParse(Result.ToString(), out decimal CurrentBalance))
                {

                    if (CurrentBalance > Value)
                        IsEnough = true;
                    
                }

            }

            catch (Exception ex)
            {

                IsEnough = false;

            }

            finally
            {

                Connection.Close();

            }

            return IsEnough;

        }

        public static bool Purchase(int ClientID, ref int CardID, string CardCode, int CardTypeID, decimal CardTypeValue)
        {

            bool IsPurchase = false;

            MySqlConnection Connection = new MySqlConnection(clsDataAccessSettings.ConnectionString);
            MySqlTransaction Transaction = null;

            string Query = @"UPDATE Clients SET Balance = Balance - @CardTypeValue WHERE ClientID = @ClientID;
                             INSERT INTO Cards (CardTypeID, ClientID, CardCode) VALUES(@CardTypeID, @ClientID, @CardCode);
                             SELECT LAST_INSERT_ID();";

            try
            {

                Connection.Open();

                Transaction = Connection.BeginTransaction();

                MySqlCommand Command = new MySqlCommand(Query, Connection, Transaction);

                Command.Parameters.AddWithValue("@ClientID", ClientID);
                Command.Parameters.AddWithValue("@CardCode", CardCode);
                Command.Parameters.AddWithValue("@CardTypeID", CardTypeID);
                Command.Parameters.AddWithValue("@CardTypeValue", CardTypeValue);

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {

                    CardID = InsertedID;
                    IsPurchase = true;
                    Transaction.Commit();

                }

                else
                {

                    IsPurchase = false;
                    Transaction.Rollback();

                }

            }

            catch (Exception ex)
            {

                IsPurchase = false;
                Transaction.Rollback();

            }

            finally
            {

                Connection.Close();

            }

            return IsPurchase;

        }

        public static DataTable GetAllCardsPurchasedByClientID(int ClientID) 
        {

            DataTable DT = null;

            MySqlConnection Connection = new MySqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT Cards.CardCode, card_types.CardTypeValue, Cards.PurchaseDate, Cards.IsRedeemed
                             FROM Cards
                             INNER JOIN card_types
                             ON Cards.CardTypeID = card_types.CardTypeID
                             WHERE ClientID = @ClientID
                             ORDER BY Cards.PurchaseDate DESC;";

            MySqlCommand Command = new MySqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ClientID", ClientID);


            try
            {

                Connection.Open();

                MySqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {

                    DT = new DataTable();
                    DT.Load(Reader);

                }

            }

            catch (Exception ex)
            {

                DT = null;

            }

            finally
            {

                Connection.Close();

            }

            return DT;

        }

    }

}
