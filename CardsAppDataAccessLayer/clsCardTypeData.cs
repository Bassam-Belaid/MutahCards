using MySql.Data.MySqlClient;
using System;
using System.Data;


namespace CardsAppDataAccessLayer
{
    public class clsCardTypeData
    {

        public static DataTable GetAllCardTypes()
        {

            DataTable DT = null;

            MySqlConnection Connection = new MySqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM card_types;";

            MySqlCommand Command = new MySqlCommand(Query, Connection);

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

        public static bool GetCardTypeByValue(ref int CardTypeID, decimal CardTypeValue)
        {

            bool IsFound = false;

            MySqlConnection Connection = new MySqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT CardTypeID FROM card_types WHERE CardTypeValue = @CardTypeValue;";

            MySqlCommand Command = new MySqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@CardTypeValue", CardTypeValue);

            try
            {

                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {

                    CardTypeID = InsertedID;
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

    }

}
