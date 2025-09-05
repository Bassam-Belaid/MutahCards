
namespace CardsAppBusinessLayer
{
    public class clsCard
    {

        private int _CardID;

        public int CardID { get { return _CardID;   } }

        private clsCardType _CardType;

        public clsCardType CardType { get { return _CardType; } }

        private string _CardCode;

        public string CardCode { get { return _CardCode; } }     

        public bool IsRedeemed { set; get; }    

        public clsCard(int CardID, clsCardType CardType, string CardCode, bool IsRedeemed = false) 
        {
        
            this._CardID = CardID;  
            this._CardType = CardType;  
            this._CardCode = CardCode;  
            this.IsRedeemed = IsRedeemed;   

        }    



    }

}
