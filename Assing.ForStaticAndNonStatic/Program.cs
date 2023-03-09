using Assing.ForStaticAndNonStatic;
using System.Security.AccessControl;

public class Program
{
    public static void Main()
    {


        int num1 = 10;
        int num2 = 20;

        CallByValueCallByReference  callByValueCallByReference = new CallByValueCallByReference();

        Console.WriteLine("Call by value Before calling function");
        Console.WriteLine($" Number1 = {num1} & Number2 = {num2}");

        callByValueCallByReference.CallByValue(num1, num2);

        Console.WriteLine("Call by value After calling function");
        Console.WriteLine($" Number1 = {num1} & Number2 = {num2}");





        Console.WriteLine("Call by refernce Before calling function");
        Console.WriteLine($" Number1 = {num1} & Number2 = {num2}");

        callByValueCallByReference.CallByReference(ref num1, ref num2);

        Console.WriteLine("Call by  After calling function");
        Console.WriteLine($" Number1 = {num1} & Number2 = {num2}");























        //int result1;
        //int Num1 = 10, Num2 = 20;

        //// //Actual parameter
        //Arithmetic arithmetic5 = new Arithmetic();
        //arithmetic5.Mul2(Num1, Num2, out result1);
        //Console.WriteLine($"Multiplication of {Num1} & {Num2} is {result1} ");


        //int resultnew = 2;

        //arithmetic5.Div1(Num1, Num2, ref resultnew);
        //Console.WriteLine($"Result = {resultnew}");



        //int Modresult = arithmetic5.Mod(100, 10);
        //Console.WriteLine(Modresult);




        //int AdditionResult = arithmetic5.ArithmeticOperations(20, 10, out int SubtractionResult, out int MultiplicationResult,
        //                       out int DivisionResult, out int ModResult);
        //Console.WriteLine($"Addition = {AdditionResult} Subtraction = {SubtractionResult} " +
        //                  $" Multiplication = {MultiplicationResult} Division = {DivisionResult}" +
        //                  $"Mod =  {ModResult}");



        //int AddResult = arithmetic5.ArithmeticOperations1(30, 20, out int SubResult, out int MulResult,
        //                  out int DivResult, out int ModResult1);
        //Console.WriteLine($"Addition = {AddResult} Subtraction = {SubResult} Multiplication = {MulResult} " +
        //                  $"Division = {DivResult} Mod = {ModResult1}");




























        //////input parameters

        //Arithmetic arithmetic = new Arithmetic();
        //arithmetic.Sub(5, 5);

        //arithmetic.Mul(7, 7);




        //////Complex type

        //Arithmetic arithmetic1 = new Arithmetic();
        //arithmetic1.X = 5;
        //arithmetic1.Y = 7;
        //arithmetic1.Z = 8;

        //arithmetic.Add(arithmetic1);


        //Arithmetic arithmetic2 = new Arithmetic();
        //arithmetic2.X = 200;
        //arithmetic2.Y = 100;

        //arithmetic.Div(arithmetic2);


        //////output parameters

        //int result;

        //arithmetic.Mul1(10, 20, out result);
        //Console.WriteLine($"Multiplication of 10 and 20 is = {result}");



        //arithmetic.Add1(25, 15, 20, out result);
        //Console.WriteLine($"Addition of 25 and 15 and 20 is = {result}");















        //Console.WriteLine("Enter object for Doc1");
        //Doctors.GetData1();





        //Console.WriteLine("Enter the data for Doctor1 object");
        //Doctors doctor1 = new Doctors();
        //doctor1.GetData();
        //doctor1.PutData();


        //Console.WriteLine("Enter the data for Doctor2 object");
        //Doctors doctor2 = new Doctors();
        //doctor2.GetData();
        //doctor2.PutData();













        //Patterns.Pattern0();

        //Patterns patternobj3 = new Patterns();
        //patternobj3.Pattern1();

        //Pattern3();

    }

    public int Number3 { get; set; }

    public void GetNumberFromUser3()
    {
        //Patterns patternobj4= new Patterns();

        Console.WriteLine("Please enter any number ");
        Number3 = Convert.ToInt32(Console.ReadLine());
        //return Number3;
    }

    public static void Pattern3()
    {
        Program programobj = new Program();
        programobj.GetNumberFromUser3();


        for (int i = 1; i <= programobj.Number3; i++)
        {
            for (int j = 1; j <= programobj.Number3; j++)
            {
                Console.Write(j + " ");
            }

            Console.WriteLine();
        }
    }
}