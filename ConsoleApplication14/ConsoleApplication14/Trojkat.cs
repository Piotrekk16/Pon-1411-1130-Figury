using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Trojkat:Figura
    {
        public Trojkat() { a = 0; b=0; }

        public Trojkat(double a,double b)
        {
            this.a = a;
            this.b = b;
        }

        
        public override double ObliczPole()
        {
            return a * b/2;
        }
    }
}
