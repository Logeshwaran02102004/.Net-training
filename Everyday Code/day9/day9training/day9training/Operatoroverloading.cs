using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace day9training
{

    public class Complex //this is for method overloading
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }

        public string lastoperator = "";  //this is for printing the last result for understanding
        public Complex(int real, int imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static Complex operator +(Complex c1, Complex c2) 
        {
            Complex result = new Complex(c1.Real + c2.Real,c1.Imaginary+c2.Imaginary);
            result.lastoperator = "+(Assition)";
            return result;
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            Complex result = new Complex(c1.Real - c2.Real, c1.Imaginary-c2.Imaginary);
            result.lastoperator = "+(subtraction)";
            return result;
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            Complex result = new Complex(c1.Real * c2.Real, c1.Imaginary*c2.Imaginary);
            result.lastoperator = "+(multiplication)";
            return result;
        }


        public static bool operator ==(Complex c1, Complex c2){
            return (c1.Real==c2.Real && c1.Imaginary==c2.Imaginary);    
            }
        public static bool operator !=(Complex c1, Complex c2)
        {
            return !(c1==c2);
        }

        public override bool  Equals(object obj)   // this is for equals inbuild to work correctly
        {
            if(obj is Complex other)
            {
                return this.Real==other.Real && this.Imaginary == other.Imaginary;
            }
            return false;
        }

        public override int GetHashCode()  // if we use inbild equals function we have to use this gethash code 
        {
            return Real.GetHashCode() ^Imaginary.GetHashCode();
        }




        public override string ToString() { 
           return $"opertion:{lastoperator}=>result = {Real}r+{Imaginary}i";
        
        }


    }
    internal class Operatoroverloading
    {
        public static void Main(string[] args)
        {

            Complex c1 = new Complex(5, 7);
            Complex c2 = new Complex(6, 8);
            Complex sum = c1 + c2;
            Complex sub = c1 - c2;
            Complex mul = c1 * c2;
            Console.WriteLine(sum);
            Console.WriteLine(sub);
            Console.WriteLine(mul);


            Console.WriteLine($"c1==c2 : {c1 == c2}");
            Console.WriteLine($"c1 != c2: {c1 != c2}");


            Console.WriteLine( c1.Equals (c2));

            Console.ReadLine();

        }
    }
}
