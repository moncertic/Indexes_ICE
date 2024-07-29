using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexes_Ice
{
    public  class Ingredients
    {

        private double price;
        private string itemNum, toppings, itemName, bunType;

        public Ingredients(double price, string itemNum, string toppings, string itemName, string bunType)
        {
            this.price = price;
            this.itemNum = itemNum;
            this.toppings = toppings;
            this.itemName = itemName;
            this.bunType = bunType;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return this.itemNum;

                else if (index == 1)
                    return this.toppings;

                else if (index == 2)

                    return this.itemName;

                else if (index == 3)
                    return this.bunType;
                else if (index == 4)
                    return this.price;
                return null;

            }
            set
            {
                if (index == 0)
                    this.itemNum = (string)value;
                else if (index == 1)
                    this.toppings = (string)value;
                else if (index == 2)
                    this.itemName = (string)value;
                else if (index == 3)
                    this.bunType = (string)value;

                else if (index == 4)
                    this.price = (double)value;
            }

        }

        public object this[string arrtName]
        {
            get
            {

                if (arrtName.ToLower().Equals("itemnum"))
                    return this.itemNum;

                else if (arrtName.ToLower().Equals("toppings"))
                    return this.toppings;
                else if (arrtName.ToLower().Equals("itemname"))
                    return this.itemName;
                else if (arrtName.ToLower().Equals("buntype"))
                    return this.bunType;
                else if (arrtName.ToLower().Equals("price"))
                    return this.price;
                return null;

            }

            set
            {
                if (arrtName.ToLower().Equals("itemnum"))
                    this.itemNum = (string)value;
                else if (arrtName.ToLower().Equals("toppings"))
                    this.toppings = (string)value;
                else if (arrtName.ToLower().Equals("itemname"))
                    this.itemName = (string)value;
                else if (arrtName.ToLower().Equals("buntype"))
                    this.bunType = (string)value;
                else if (arrtName.ToLower().Equals("price"))
                    this.price = (double)value;

            }


        }



    }





}

