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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello welcome to the Farm");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();

            Console.Write(" |A for horse|B for pig|C for Duck|D for goat| pick a animal to visit: ");

            bool pickedanimal = false;
            do
            {
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
                    Console.WriteLine("Press Enter for the next Animal");
                    pickedanimal = true;
                 
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
                    Console.WriteLine("Press Enter for the next Animal");
                    pickedanimal = true;

                }
                else if (Pick.ToLower() == "c")
                {
                    duck firstduck = new duck();
                    firstduck.DuckSpeak();
                    duck secondduck = new duck();
                    secondduck.Duckfood();
                    duck thirdduck = new duck();
                    thirdduck.DuckWeight();
                    duck forthduck = new duck();
                    forthduck.DuckSpeed();
                    Console.WriteLine("Press Enter for the next Animal");
                    pickedanimal = true;
                }
                else if (Pick.ToLower() == "d")
                {
                    goat firstgoat = new goat();
                    firstgoat.GoatSpeak();
                    goat secondgoat = new goat();
                    secondgoat.Goatfood();
                    goat thirdgoat = new goat();
                    thirdgoat.GoatWeight();
                    goat forthgoat = new goat();
                    forthgoat.GoatSpeed();
                    Console.WriteLine("Press Enter for the next Animal");
                    pickedanimal = true;
                }
                else
                {
                    Console.WriteLine("choose A-B-C or D  :");
                    Console.WriteLine("Then click enter");
                }

            } while (pickedanimal == true);
        }
    }
}
