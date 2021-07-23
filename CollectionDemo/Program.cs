using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Collection Demo Program");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {

                case 1:
                    List.ListDemo();
                    break;

                case 2:
                    Stack.StackDemo();
                    break;

                case 3:
                    Queue.QueueDemo();
                    break;

                default:
                    break;


            }
        }
    }
}
