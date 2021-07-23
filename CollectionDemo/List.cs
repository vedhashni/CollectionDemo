using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class List
    {
        public static void ListDemo()

        {
            
            var cities = new List<string>();

            
            string[] popularCities = new string[3] { "London", " Germany", "France" };

            //Addding elements to list
            cities.Add("New York");
            cities.Add("Newzland");
            cities.Add("Paris");
            cities.Add("San fransico");

            
            Console.WriteLine("\nCities list are :\n");
            //list is accessed
            foreach (var c in cities)
            {
                Console.WriteLine("The cities are : {0} ", c);
            }

            //AddRange-Adding range of elements
            cities.AddRange(popularCities);
            Console.WriteLine("\nAfter adding more cities list are :\n ");
            foreach (var c in cities)
            {
                Console.WriteLine("The cities are : {0} ", c);
            }

        }
    }
}
