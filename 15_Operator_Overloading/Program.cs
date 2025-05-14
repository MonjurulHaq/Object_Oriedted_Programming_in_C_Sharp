using System;
using System.Collections.Concurrent;
using System.Runtime.Serialization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber c1 = new ComplexNumber(6, 8);
            ComplexNumber c2 = new ComplexNumber(2, 5);

            ComplexNumber c3 = c1+c2;

            ComplexNumber c4 = c1 + 9;

            ComplexNumber c5 = new ComplexNumber(0, 3);
            c5 += 2;

            c5--;

            c1.displayComplex();
            c2.displayComplex();
            c3.displayComplex();
            c4.displayComplex();
            c5.displayComplex();

            Console.WriteLine("c1 == c2: " + (c1 == c2));
            Console.WriteLine("c1 != c2: " + (c1 != c2));

            Console.WriteLine("c3 > c4: " + (c3 > c4));
            Console.WriteLine("c3 < c4: " + (c3 < c4));
        }
    }

    class ComplexNumber{
        public int real;
        public int imaginary;
        
        public ComplexNumber(int real, int imaginary){
            this.real = real;
            this.imaginary = imaginary;
        }

        public void displayComplex(){
            Console.WriteLine($"{real} + {imaginary}i");
        }

        public static ComplexNumber operator + (ComplexNumber c1, ComplexNumber c2){
            int newReal = c1.real + c2.real;
            int newImaginary = c1.imaginary + c2.imaginary;

            ComplexNumber c3 = new ComplexNumber(newReal, newImaginary);
            return c3;
        }

        public static ComplexNumber operator + (ComplexNumber c1, int x){
            int newReal = c1.real + x;
            int newImaginary = c1.imaginary + x;

            ComplexNumber c3 = new ComplexNumber(newReal, newImaginary);
            return c3;
        }

        public static ComplexNumber operator --(ComplexNumber c1){
            int newReal = c1.real--;
            int newImaginary = c1.imaginary--;

            ComplexNumber c3 = new ComplexNumber(newReal, newImaginary);
            return c3;
        }

        public static bool operator == (ComplexNumber c1, ComplexNumber c2){
            bool isRealEqual = c1.real == c2.real;
            bool isImaginaryEqual = c1.imaginary == c2.imaginary;
            return isRealEqual && isImaginaryEqual;
        }

        public static bool operator != (ComplexNumber c1, ComplexNumber c2){
            return !(c1 == c2);
        }

        public static bool operator > (ComplexNumber c1, ComplexNumber c2){
            bool isRealGreater = c1.real > c2.real;
            bool isImaginaryGreater = c1.imaginary > c2.imaginary;
            return isRealGreater && isImaginaryGreater;
        } 

        public static bool operator < (ComplexNumber c1, ComplexNumber c2){
            return !(c1 > c2);
        }
    }
}