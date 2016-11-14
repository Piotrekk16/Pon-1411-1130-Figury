using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Figura kw1 = new Kwadrat(2);
            //Console.WriteLine(kw1.ObliczPole());
            //Trojkat tr1 = new Trojkat(3, 11);
            //Console.WriteLine(tr1.ObliczPole());

            List<Figura> figury = new List<Figura>();
            figury.Add(new Kwadrat(6));
            figury.Add(new Trojkat(3, 5));
            figury.Add(new Kwadrat(2));
            figury.Add(new Trojkat(3, 44));
            figury.Add(new Kwadrat(1));
            figury.Add(new Trojkat(9, 7));

            foreach (var element in figury)
            {
                Console.WriteLine(element.ObliczPole());
            }

            Figura f1 = new Kwadrat();

            Console.ReadKey();

        }
    }
}
