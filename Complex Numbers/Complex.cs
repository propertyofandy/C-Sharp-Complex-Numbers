using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Complex_Numbers
{
    public struct Complex
    {
        public double Real { get; private set; }
        public double Imaginary { get; private set; }
        public double Modulus
        {
            get { return Math.Sqrt(Real * Real + Imaginary * Imaginary); }
        }

        public Complex(double real = 0, double i = 0)
        {
            Real = real;
            Imaginary = i;
        }

        override
        public string ToString()
        {
            if(Imaginary == 0)
            {
                return $"{Real}";
            }
            else if (Imaginary < 0)
            {
                return $"{Real} - {-Imaginary}i";
            }
            return $"{Real} + {Imaginary}i";
        }



        
    }
}
