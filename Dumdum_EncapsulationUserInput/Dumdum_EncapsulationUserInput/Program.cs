using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dumdum_EncapsulationUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Begin:
            Console.Clear();

            // Userinput for brand and size
            Console.WriteLine("Your Shoe Info!!!");
            Console.Write("Input Brand: ");
            string brand = Console.ReadLine();
            Console.Write("Input Size: ");
            int size = Convert.ToInt32(Console.ReadLine());

            // Instantiate an object
            Shoe shoe = new Shoe { Brand = brand, Size = size };
            // Method
            shoe.DisplayShoeInfo();

            //User choice if it want to continue or not
            Console.WriteLine("Do you want to try another shoe? (Yes or No)");
            string userinfo = Console.ReadLine().ToLower();

            if (userinfo == "yes")
            {
                goto Begin;
            }
            else
            {
                return;
            }
        }
    }
}
