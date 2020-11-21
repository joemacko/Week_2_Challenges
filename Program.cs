using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //New up (instantiate) an instance of Greeter class inside Main method
            Greeter greeter = new Greeter();
            
            //From this instance, call all of the methods you've built out

            //Hello method
            string nameOne = greeter.Hello("Nora");
            Console.WriteLine(nameOne);

            //Goodbye method
            string nameTwo = greeter.Goodbye("Joe");
            Console.WriteLine(nameTwo);

            //TimeOfDay method
            greeter.TimeOfDay();
            Console.ReadLine();
        }
    }
}
