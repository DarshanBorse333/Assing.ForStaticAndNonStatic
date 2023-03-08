using Assing.ForStaticAndNonStatic;
using System.Security.AccessControl;

public class Program
{
    public static void Main()
    {

        ////input parameters

        Arithmetic arithmetic = new Arithmetic();
        arithmetic.Sub(5, 5);

        arithmetic.Mul(7, 7);

        
        

        ////Complex type
        
        Arithmetic arithmetic1 = new Arithmetic();
        arithmetic1.X = 5;
        arithmetic1.Y = 7;
        arithmetic1.Z = 8;

        arithmetic.Add(arithmetic1);


        Arithmetic arithmetic2 = new Arithmetic();
        arithmetic2.X = 200;
        arithmetic2.Y = 100;

        arithmetic.Div(arithmetic2);


        ////output parameters

        int result;

        arithmetic.Mul1(10, 20, out result);
        Console.WriteLine($"Multiplication of 10 and 20 is = {result}");



        arithmetic.Add1(25, 15, 20, out result);
        Console.WriteLine($"Addition of 25 and 15 and 20 is = {result}");
        
        









        
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