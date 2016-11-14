using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Kwadrat :Figura
    {
        public Kwadrat() { a = 0; }

        public Kwadrat(double a)
        {
            this.a = a;
        }

        
        public override double ObliczPole()
        {
            return a * a;
        }
    }
}
