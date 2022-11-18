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
        public double Real { get; set; }
        public double Imaginary { get; set; }
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
            if(Real == 0 && Imaginary == 0)
            {
                return $"0";
            }
            else if(Imaginary == 0)
            {
                return $"{Real}";
            }
            else if (Imaginary < 0)
            {
                return $"{Real} - {-Imaginary}i";
            }
            else if (Real == 0)
            {
                return $"{Imaginary}i";
            }
            
            return $"{Real} + {Imaginary}i";
        }

        
        //overloading math operators
        
        public static Complex operator +(Complex c, Complex c2)
        {
            Complex resault = new Complex();

            resault.Real = c.Real+c2.Real;
            resault.Imaginary = c.Imaginary+c2.Imaginary;

            return resault;
        }

        public static Complex operator -(Complex c, Complex c2)
        {
            Complex resault = new Complex();

            resault.Real = c.Real - c2.Real;
            resault.Imaginary = c.Imaginary - c2.Imaginary;

            return resault;
        }

        public static Complex operator *(Complex c, Complex c2)
        {
            Complex resault = new Complex();

            resault.Real = c.Real*c2.Real+c.Imaginary*c2.Imaginary*-1;
            resault.Imaginary = c.Real*c2.Imaginary+c.Imaginary*c2.Real ;

            return resault;
        }

        public static Complex operator /(Complex c, Complex c2)
        {
            Complex resault = new Complex();

            resault.Real = c.Real/c2.Real + c.Imaginary/c2.Imaginary;
            resault.Imaginary = 0;

            return resault;
        }

        public static Complex operator ^(Complex c, int exponent)
        {
            Complex resault = new Complex();

            if (exponent % 4 == 0)
            {
                resault.Real = c.Real * c.Real+ c.Imaginary*c.Imaginary;
                resault.Imaginary = 0;
            }
            else if(exponent%3 == 0)
            {
                resault.Real = c.Real * c.Real;
                resault.Imaginary = c.Imaginary * c.Imaginary * -1;

            }
            else if(exponent%2 == 0)
            {
                resault.Real = c.Real * c.Real - c.Imaginary * c.Imaginary;
                resault.Imaginary = 0;
            }
            else
            {
                resault.Real = c.Real*c.Real;
                resault.Imaginary = c.Imaginary*c.Imaginary;
            }

            return resault; 

        }



    }
}
