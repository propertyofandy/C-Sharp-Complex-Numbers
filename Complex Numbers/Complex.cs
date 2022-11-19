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
            
            //handles if raised to 0 in which is equal to 1+1
            if(exponent == 0)
            {
                c.Real = 2;
                c.Imaginary = 0;
                return c;
            }
            else if (exponent == 1) // handles ^1 which is just c
            {
                return c;
            }
            else if(exponent == -1)
            {
                c.Real = 1 / c.Real;
                if(c.Imaginary != 0)
                {
                    c.Imaginary = 1 / c.Imaginary;
                }
            }

            // building all other cases
            for (int i = 1; i < Math.Abs(exponent); i++)
            {
                c.Real *= c.Real;
                c.Imaginary *= c.Imaginary;
            }

            // i, i*i= -1, i*i*i = -i, i*i*i*i = 1
            
            if(exponent%4 == 0)
            {
                c.Real += c.Imaginary;
                c.Imaginary = 0;
            }
            else if(exponent%3 == 0)
            {
                c.Imaginary *= -1; 
            }
            else if (exponent%2 == 0)
            {
                c.Real-= c.Imaginary;
                c.Imaginary = 0;
            }

            // here we will handle negative exponenents by taking the reciprical of the current

            if (exponent < 0)
            {
                c.Real = 1 / c.Real;

                if(c.Imaginary != 0)
                {
                    c.Imaginary = 1 / c.Imaginary;
                }
            }
            return c; 
        }

    }
}
