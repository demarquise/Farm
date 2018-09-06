using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingAfarm
{
    class horse
    {
       static  string speak = "heewbrraa";


        public void SpeakNow()
        {
            Console.WriteLine("This is the horse Salty ");
            Console.WriteLine(" the horse goes " + speak);
        }
        public void Eatfood()
        {
            Console.WriteLine("The horse eats hay and grasss");
        }
        public void Weight()
        {
            Console.WriteLine("The horse ways 700lb");
        }
        public void Speed()
        {
            Console.WriteLine("The horse runs 30 miles per hour");
        }
    }
}
