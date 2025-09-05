
using CardsAppDataAccessLayer;
using System.Collections.Generic;
using System.Data;

namespace CardsAppBusinessLayer
{
    public class clsCardType
    {

        private int _CodeTypeID;

        public int CodeTypeID { get { return _CodeTypeID; } }

        private decimal _CardTypeValue;

        public decimal CardTypeValue { get { return _CardTypeValue; } }     

        public clsCardType(int CodeTypeID, decimal CardTypeValue)
        {

            this._CodeTypeID = CodeTypeID;  
            this._CardTypeValue = CardTypeValue;    

        }

        private static List<clsCardType> _GetCardTypes()
        {

            DataTable DT = null;
            List<clsCardType> CardTypes = null;

            if ((DT = clsCardTypeData.GetAllCardTypes()) != null)
            {

                CardTypes = new List<clsCardType>();    

                foreach (DataRow Row in DT.Rows) 
                {

                    CardTypes.Add(new clsCardType((int)Row["CardTypeID"], (decimal)Row["CardTypeValue"]));

                }

            }

            return CardTypes;   

        }

        public static List<clsCardType> GetCardTypes() 
        {
        
            return _GetCardTypes(); 

        }

        public static clsCardType GetCardTypeByValue(decimal CardTypeValue) 
        {

            int CardTypeID = -1;

            if(clsCardTypeData.GetCardTypeByValue(ref CardTypeID, CardTypeValue))
                return new clsCardType(CardTypeID, CardTypeValue);  

            else
                return null;    

        }   

    }

}
