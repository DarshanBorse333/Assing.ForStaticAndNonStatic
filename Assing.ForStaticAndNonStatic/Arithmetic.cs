using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assing.ForStaticAndNonStatic
{
    internal class Arithmetic
    {

        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }



        ////input parameters 
        public void Sub(int Num1 , int Num2)   
        {
            int result = Num1 - Num2;
            Console.WriteLine($"Subtraction of {Num1} and {Num2} is = {result}");
        }

        public void Mul(int Num1, int Num2)
        {
            int result = Num1 * Num2;
            Console.WriteLine($"Multilication of {Num1} and {Num2} is = {result}");
        }


        ////Complex type 
        

        public void Add(Arithmetic arth)
        {
            int result = arth.X + arth.Y + arth.Z;
            Console.WriteLine($"Addition of {arth.X} and {arth.Y} and {arth.Z} is = {result}");
        }


        public void Div(Arithmetic arth)
        {
            int result = arth.X / arth.Y;
            Console.WriteLine($"Division of {arth.X} and {arth.Y} is = {result}");
        }



        ////Output Paramters 
        

        public void Mul1(int num1 , int num2, out int result)
        {
            result = num1 * num2;
        }

        public void Add1(int num1, int num2, int num3, out int result)
        {
            result= num1 + num2 + num3;
        }
    }
}
