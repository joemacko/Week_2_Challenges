using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Challenges
{
    //Build a class called Greeter. This class will hold our next few methods.
    public class Greeter
    {
        /*Inside our new class, build a method that takes in a name as a parameter
        and then outputs (writes to the Console) hello to that person.*/
        public string Hello(string name)
        {
            return $"Hello, {name}";
        }

        /*Build another method that outputs (writes to the Console) some sort of 
        farewell to the name it is given as a parameter*/
        public string Goodbye(string name)
        {
            return $"Goodbye, {name}";
        }

        /*Build a method that outputs (writes to the Console)
        Good Morning/Afternoon/Evening/Night depending on the time of day.*/
        public void TimeOfDay()
        {
            DateTime present = new DateTime();
            present = DateTime.Now;

            if (present.Hour <= 6 )
            {
                Console.WriteLine("Night");
            }
            else if (present.Hour <= 12)
            {
                Console.WriteLine("Good Morning");
            }
            else if (present.Hour <= 18)
            {
                Console.WriteLine("Afternoon");
            }
            else if (present.Hour <= 24)
            {
                Console.WriteLine("Evening");
            }
            else
            {
                Console.WriteLine("Our clock is messed up!");
            }
        }
    }
}
