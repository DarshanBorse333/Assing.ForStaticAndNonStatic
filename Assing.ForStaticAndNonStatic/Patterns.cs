using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assing.ForStaticAndNonStatic
{
    internal class Patterns
    {
        //Global Variables

        int Number1 { get; set; }

        int Number2 { get; set; }


  
        void GetNumberFromUser1()
        {
            

            Console.WriteLine("Please enter any number ");
            Number1 = Convert.ToInt32(Console.ReadLine());
           
        }

        public int GetNumberFromUser2()
        {
            Console.WriteLine("Please enter any number ");
            Number2 = Convert.ToInt32(Console.ReadLine());
            return Number2;
        }

        public static void Pattern0()
        {

            Patterns patternobj = new Patterns();     
            patternobj.GetNumberFromUser2();


            for (int i = 1; i <= patternobj.Number2; i++)
            {
                for (int j = 1; j <= patternobj.Number2; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }

        public void Pattern1()
        {
            

            GetNumberFromUser1();

            for (int i = Number1; i >= 1; i--)
            {
                for (int j = Number1; j >= 1; j--)
                {
                    Console.Write(" " + Convert.ToChar(64 + j));
                }

                Console.WriteLine();

            }
            
        }
    }
}
