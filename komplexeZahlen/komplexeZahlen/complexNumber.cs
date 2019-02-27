using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komplexeZahlen
{
    class complexNumber
    {
        public double real;
        public double imaginary;

        public double amount;
        public double angle;

        public complexNumber(double? Real = null, double? Imag = null, double? Amount = null, double? Angle = null)
        {
            if (Real.HasValue && Imag.HasValue)
            {
                // Assign real + imag to parameters
                this.real = Real.Value;
                this.imaginary = Imag.Value;

                // Calculate ammount + phi
                this.amount = returnAmount();
                this.angle = returnPhi();
            }
            else if (Amount.HasValue && Angle.HasValue)
            {
                // Assign amount + phi to parameters
                this.amount = Amount.Value;
                this.angle = Angle.Value;

                // Calculate real + imag
                this.real = returnReal();
                this.imaginary = returnImaginary();
            }
            else
                throw new ArgumentNullException();
        }

        public double returnPhi()
        {
            if(this.real > 0)
            {
                return Math.Round(Math.Atan(this.imaginary / this.real) / (Math.PI / 180), 3);
            }
            else if(this.real < 0 && this.imaginary >= 0)
            {
                return Math.Round((Math.Atan(this.imaginary / this.real) + Math.PI) / (Math.PI / 180), 3);
            }
            else if(this.real < 0 && this.imaginary < 0)
            {
                return Math.Round((Math.Atan(this.imaginary / this.real) - Math.PI) / (Math.PI / 180), 3);
            }
            else if(this.real == 0 && this.imaginary > 0)
            {
                return Math.Round((Math.PI / 2) / (Math.PI / 180), 3);
            }
            else if(this.real == 0 && this.imaginary < 0)
            {
                return Math.Round((-1 * (Math.PI / 2)) / (Math.PI / 180), 3);
            }
            return 0;
        }

        public double returnAmount()
        {
            return Math.Round(Math.Sqrt(this.real * this.real + this.imaginary * this.imaginary), 3);
        }

        public double returnReal()
        {
            return Math.Round(this.amount * Math.Cos(this.angle * (Math.PI / 180)), 3);
        }

        public double returnImaginary()
        {
            return Math.Round(this.amount * Math.Sin(this.angle * (Math.PI / 180)), 3);
        }

        public complexNumber addition(complexNumber Z2)
        {
            double Real = this.real + Z2.real;
            double Imag = this.imaginary + Z2.imaginary;
            complexNumber solution = new complexNumber( Real: Real, Imag: Imag);
            return solution;
        }

        public complexNumber subtraction(complexNumber Z2)
        {
            double Real = this.real - Z2.real;
            double Imag = this.imaginary - Z2.imaginary;
            complexNumber solution = new complexNumber(Real: Real, Imag: Imag);
            return solution;
        }

        public complexNumber multiplication(complexNumber Z2)
        {
            
            double Real = this.real * Z2.real - this.imaginary * Z2.imaginary;
            double Imag = this.real * Z2.imaginary + this.imaginary * Z2.real;
            complexNumber solution = new complexNumber(Real:Real, Imag:Imag);
            return solution;
        }

        public complexNumber division(complexNumber Z2)
        {
            double a, b, c;
            a = this.real * Z2.real + this.imaginary * Z2.real;
            b = this.imaginary * Z2.real - this.real * Z2.real;
            c = Z2.real * Z2.real + Z2.imaginary * Z2.imaginary;

            double Real = Math.Round((a / c), 3);
            double Imag = Math.Round((b / c), 3);
            complexNumber solution = new complexNumber(Real:Real, Imag:Imag);
            return solution;
        }
    }
}
