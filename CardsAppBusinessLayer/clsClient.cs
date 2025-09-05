using CardsAppDataAccessLayer;
using CodeGenerator;
using System.Data;

namespace CardsAppBusinessLayer
{
    public class clsClient
    {

        private int _ClientID;

        public int ClientID { get { return _ClientID; } }

        private string _Username;

        public string Username { get { return _Username; } }

        private string _Password;

        public string Password { get { return _Password; } }

        private decimal _Balance;

        public decimal Balance { get { return _Balance; } }

        public clsClient(int ClientID, string Username, string Paswword, decimal Balance) {
        
            this._ClientID = ClientID;  
            this._Username = Username;  
            this._Password = Paswword;  
            this._Balance = Balance;    

        }

        public static clsClient FindClient(string Username, string Password)
        {

            int ClientID = -1;
            string StoredPassword = "";
            decimal Balance = 0;

            if (clsClientData.FindClient(ref ClientID, Username, ref StoredPassword, ref Balance) &&  Password == StoredPassword)
                return new clsClient(ClientID, Username, Password, Balance);

            else
                return null;

        }

        public static bool CheckClientBalance(int ClientID, decimal Value) 
        {
        
            return clsClientData.CheckClientBalance(ClientID, Value); 

        }

        public clsCard Purchase(clsCardType CardType)
        {

            int CardID = -1;
            string CardCode = clsCode.GenerateCode();

            if (clsClientData.Purchase(this._ClientID, ref CardID, CardCode, CardType.CodeTypeID, CardType.CardTypeValue))
            {

                this._Balance = this.Balance - CardType.CardTypeValue;    
                return new clsCard(CardID, CardType, CardCode);

            }

            else
                return null;    

        }

        public DataTable GetAllPurchasedCards()
        {

            return clsClientData.GetAllCardsPurchasedByClientID(this._ClientID);

        }

    }
}
