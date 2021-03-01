using System;

namespace Exo_Slide_07
{
    class Program
    {
        static void Main(string[] args)
        {
            EquationSecondDegre eqsd = new EquationSecondDegre();
            eqsd.A = 4;
            eqsd.B = 4;
            eqsd.C = 1;

            double? x1;
            double? x2;

            if (eqsd.Resoudre(out x1, out x2))
            {
                if (x1 == x2)
                {
                    Console.WriteLine($"{eqsd.A}X² + {eqsd.B}X + {eqsd.C} = 0 => à une solution {x1}");
                }
                else
                {
                    Console.WriteLine($"{eqsd.A}X² + {eqsd.B}X + {eqsd.C} = 0 => à deux solutions {x1} et {x2}");
                }
            }
            else {
                Console.WriteLine($"{eqsd.A}X² + {eqsd.B}X + {eqsd.C} = 0 => n'a pas de solution");
            }
        }
    }
}
