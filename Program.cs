using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvadratuli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sheiyvanet kvadratuli gantolebis 3 parametri: a, b, c");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a == 0) {
                Console.WriteLine("a ar unda iyos 0");
            }

            else {
                double discr = Math.Pow(b, 2) - 4 * a * c;

                if (discr < 0)
                {
                    Console.WriteLine("Gantolebas ar aqvs amoanxsni");
                }

                else if (discr == 0) {
                    double amonaxsni1 = -b / (2 * a);
                    Console.WriteLine("Am gantolebas aqvs erti amonaxsni: " + amonaxsni1);
                }

                else
                {
                    double discrf = Math.Pow(discr, 0.5);
                    double amonaxsni1 = (-b - discrf) / (2 * a);
                    double amonaxsni2 = (-b + discrf) / (2 * a);
                    Console.WriteLine("am gantolebas aqvs ori amonaxsni: " + amonaxsni1 + " " + amonaxsni2);
                }

            }
            Console.ReadKey();
        }
    }
}
