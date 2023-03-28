using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MainOperation
{

    public class Product
    {
        
        int _numberOfItem = 0;
        string _productId = "";
        decimal _price = 0;


        public string _rubrixCube()
        {
            string _productID = "";
            decimal _price = 9.99;

            return string.Empty;

        }

        public string _monoployDeal()
        {
            string _productId = "";
            decimal _price = 5.99;

            return string.Empty;

        }

        public string _Xbox1()
        {

            string _productID = "";
            decimal _price = 599.99;

            return string.Empty;

        }

        public int _priceOfProduct()
        {
            if(_priceOfProduct = _Xbox1)
            {

                int _totalPrice = _Xbox1._price * _numberOfItem;

                return _totalPrice;
            }

            else if(_priceOfProduct = _monoployDeal)
            {

                int _totalPrice = _monoployDeal._price * _numberOfItem;

                return _totalPrice;
            }

            else
            {
                int _totalPrice = _rubrixCube._price * _numberOfItem;

                return _totalPrice;
            }


        }




    }


}