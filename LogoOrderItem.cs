/*
 * Progammer: Sergio Mendoza
 * Email: smendozagomez@cnm.edu
 * Class: CIS 1280
 * 06/10/20
 * Program: MendozaP3
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO:  Good job, just be carefult of your properties  98/100

namespace MendozaP3
{
  
    class LogoOrderItem
    {

        private const decimal USB = 4.00M, MUG = 3.50M, PEN = 1.00M, 
            LOGO_PRICE = 0.10M, PRICE_PER_COLOR = 0.03M, PRICE_FOR_TEXT = 0.05M;

        private bool hasLogo;
        public bool HasLogo
        {
            get { return hasLogo; }
            set { hasLogo = value; Calc(); }
        }

        private string itemType;
        public string ItemType
        {
            get { return itemType; }
            set { itemType = value; Calc(); }
        }

        private int numColors;
        public int NumColors
        {
            get { return numColors; }
            set { numColors = value; Calc(); }
        }

        private int numItems;
        public int NumItems
        {
            get { return numItems; }
            set { numItems = value; Calc(); }
        }

        private string txt;
        public string Txt
        {
            get { return txt; }
            set { txt = value; Calc(); }
        }
        //---------------------------------------------------------------------------------------------

        //
        public int ItemID { get; set; }
        
        public decimal Price { get; private set; }
    //TODO: This should not be an auto-property. You have another  -2
    //TODO: similarly name private field and property txt.  Why have two?
    //TODO:  The one you named Txt is the correct Property because it allows
    //TODO:  for the call to Calc()
        public string Text { get; set; }

        //----------------------------------------------------------------------------------------------

        //Constructors
        public LogoOrderItem() : this(-1, "Mug", 0, 0, 1, "", false)
        {

        }
        public LogoOrderItem(string text, bool hasLogo)
            : this(1, "Mug", -1, 1, 1, text, hasLogo)
        {
            
        }

        public LogoOrderItem(int itemID, string ItemType, int numCols, int nItems, decimal price, string Text, bool HasLogo)
        {

            //value = itemID;
            this.itemType = ItemType;
            this.numColors = numCols;
            this.numItems = nItems;
            this.Text = Text;
            this.hasLogo = HasLogo;

        }


       // public bool HasLogo{ get; set; }
       // public int ItemID { get; set; }
       // //public string ItemType { get; set; }
       //// public int NumColors { get; set; }
       // public int NumItems { get; set;  }
       // public decimal Price { get; set; }
        

        private void Calc()
        {
            decimal basePrice = ItemType.Equals("USB")  ? USB : ItemType.Equals("Mug") ? MUG : PEN;
            if (ItemType.Equals( "USB"))
            {
                basePrice = USB;
            }
            else if(ItemType.Equals( "Mug"))
            {
                basePrice = MUG;
            }else
            {
                basePrice = PEN;
            }
            //check whth the hasLogo to see if we add something with colors 
            if (hasLogo == true)
            {
                basePrice += LOGO_PRICE;

                basePrice += PRICE_PER_COLOR * NumColors;
                if ( !Text.Trim().Equals(""))
                {
                    basePrice += PRICE_FOR_TEXT;
                }
                
            }
            //add price for the text
            Price = basePrice * NumItems;

        }
        public string GetOrderSummary()
        {
            //Fairly ong so that yo report te items ordered and the total cost
            txt = "\r\nOrder #:" + ItemID + 
                ".\r\n" + numItems + " Mugs with " + numColors + " colors was Placed"+
                "\r\n Engraving: \" " + Text +
                 " \". \r\nTotal Price: " + Price;
            return txt;
        }


    }

}
