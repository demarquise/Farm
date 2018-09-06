using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingAfarm
{
    class Program
    {
        static string Pick;
        static void Main(string[] args)
        {
            // this the main intro to the farm 
            Console.WriteLine("Hello welcome to the Farm");
            Console.ReadLine();
            Console.WriteLine("these are our aniamls ");
            Console.ReadLine();
            Console.Clear();

            Console.Write(" |A for horse|B for pig|C for sheep|D for goat| pick a animal to visit: ");

            Pick = Console.ReadLine();

            if (Pick.ToLower() == "a")
            {
                horse jerry = new horse();
                jerry.SpeakNow();
                horse mat = new horse();
                mat.Eatfood();
                horse dave = new horse();
                dave.Weight();
                horse top = new horse();
                top.Speed();
            }
            else if (Pick.ToLower() == "b")
            {
                pig firstpig = new pig();
                firstpig.Speakpig();
                pig secondpig = new pig();
                secondpig.Pigfood();
                pig thirdpig = new pig();
                thirdpig.PigWeight();
                pig forthpig = new pig();
                forthpig.PigSpeed();
            }

        }
    }
}
