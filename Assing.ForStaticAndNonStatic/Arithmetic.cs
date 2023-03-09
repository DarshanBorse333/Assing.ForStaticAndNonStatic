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
        public void Sub(int Num1, int Num2)
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


        public void Mul1(int num1, int num2, out int result)
        {
            result = num1 * num2;
        }

        public void Add1(int num1, int num2, int num3, out int result)
        {
            result = num1 + num2 + num3;
        }








        ////output formal parameter

        public void Mul2(int Num1, int Num2, out int result1)
        {
            result1 = Num1 * Num2;
        }

        //// input output parameters / ref


        public void Div1(int a, int b, ref int resultnew)
        {
            resultnew = resultnew + b / a;
        }

        public int Mod(int Num1, int Num2)
        {
            int result = Num1 % Num2;
            return result;
        }

        public int ArithmeticOperations(int a, int b, out int SubtractionResult, out int MultiplicationResult,
                                        out int DivisionResult, out int Modresult)
        {
            int AdditionResult = a + b;
            SubtractionResult = a - b;
            MultiplicationResult = a * b;
            DivisionResult = a / b;
            Modresult = a % b;

            return AdditionResult;
        }

        public int ArithmeticOperations1(int x, int y, out int SubResult, out int MulResult, out int DivResult,
                                         out int ModResult1)
        {
            int AddResult = x + y;
            SubResult = x - y;
            MulResult = x * y;
            DivResult = x / y;
            ModResult1 = x % y;

            return AddResult;
        }
    }
}
