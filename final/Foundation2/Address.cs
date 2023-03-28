using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MainOperation
{
        public class Address
        {
            public string _country = "";

            
            private string AddressOfCustomer()
            {
                
                Console.WriteLine("Please Enter your Address");
                Console.WriteLine("Street Address: ");
                string _streetAddress = Console.ReadLine(); 
                Console.WriteLine("City: ");
                string _city = Console.ReadLine();
                Console.WriteLine("State: ");
                string _state = Console.ReadLine();
                Console.WriteLine("Country: ");
                string _country = Console.ReadLine();


                Console.WriteLine(_streetAddress + _city + _state + _country);
                string _fullAddress = Console.ReadLine();

                return _fullAddress;



            }






        }
















}