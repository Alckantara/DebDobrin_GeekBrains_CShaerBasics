using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DataClasses
{
    public struct ComplexNumber
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }
    }

    public class Complex
    {
        public readonly ComplexNumber value;

        public Complex(int a, int b)
        {
            value.Real = a;
            value.Imaginary = b;
        }

        public static Complex operator -(Complex complex1, Complex complex2)
        {
            int realUnit = complex1.value.Real - complex2.value.Real;
            int imaginaryUnit = complex1.value.Imaginary - complex2.value.Imaginary;

            return new Complex(realUnit, imaginaryUnit);
        }

        public static Complex operator +(Complex complex1, Complex complex2)
        {
            int realUnit = complex1.value.Real + complex2.value.Real;
            int imaginaryUnit = complex1.value.Imaginary + complex2.value.Imaginary;

            return new Complex(realUnit, imaginaryUnit);
        }

        public static Complex operator *(Complex complex1, Complex complex2)
        {
            int realUnit = (complex1.value.Real * complex2.value.Real) - (complex1.value.Imaginary * complex2.value.Imaginary);
            int imaginaryUnit = (complex1.value.Real * complex2.value.Imaginary) + (complex2.value.Real * complex1.value.Imaginary);

            return new Complex(realUnit, imaginaryUnit);
        }

        public static Complex operator /(Complex complex1, Complex complex2)
        {
            int realUnit = ((complex1.value.Real * complex2.value.Real) + (complex1.value.Imaginary * complex2.value.Imaginary)) / 
                ((complex2.value.Real * complex2.value.Real) + (complex2.value.Imaginary * complex2.value.Imaginary));

            int imaginaryUnit = ((complex2.value.Real * complex1.value.Imaginary) - (complex1.value.Real * complex2.value.Imaginary)) /
                ((complex2.value.Real * complex2.value.Real) + (complex2.value.Imaginary * complex2.value.Imaginary));

            return new Complex(realUnit, imaginaryUnit);
        }

        public static bool operator ==(Complex complex1, Complex complex2)
        {
            bool isRealUnitOk = complex1.value.Real == complex2.value.Real;
            bool isImaginaryUnitOk = complex1.value.Imaginary == complex2.value.Imaginary;

            return isRealUnitOk && isImaginaryUnitOk;
        }

        public static bool operator !=(Complex complex1, Complex complex2) => 
            !(complex1 == complex2);

        public override string ToString() =>
            $"{ value.Real } + { value.Imaginary }i";
    }
}
