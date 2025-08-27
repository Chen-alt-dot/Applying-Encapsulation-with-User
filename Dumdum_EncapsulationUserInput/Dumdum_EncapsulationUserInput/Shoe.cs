using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dumdum_EncapsulationUserInput
{
    internal class Shoe
    {
        // Name: Christian Benedict P. Dumdum
        // Section: IT301
        // EXER_05: Applying Encapsulation with User

        //Private Fields
        private string brand;
        private int size;


        // Public property for Brand
        public string Brand { get; set; }
        // Public property for Size
        public int Size { get; set; }

        //Method
        public void DisplayShoeInfo()
        {
            Console.WriteLine("Your Brand is " + Brand + " the size is " + Size);
        }
    }
}
