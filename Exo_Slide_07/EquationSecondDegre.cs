using System;
using System.Collections.Generic;
using System.Text;

namespace Exo_Slide_07
{
    public struct EquationSecondDegre
    {
        public double A, B, C;

        public bool Resoudre(out double? X1, out Nullable<double> X2)
        {
            X1 = X2 = default;
            if (A == 0) return false;
            double delta = (Math.Pow(B, 2)) - (4 * A * C);
            if (delta < 0) return false;
            else if (delta == 0)
            {
                X1 = X2 = -B / (2 * A);
                //X1 = -B / (2 * A);
            }
            else
            {
                X1 = (-B - Math.Sqrt(delta)) / (2 * A);
                X2 = (-B + Math.Sqrt(delta)) / (2 * A);
            }
            return true;
        }
    }
}
