using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assing.ForStaticAndNonStatic
{
    internal class Doctors
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int GrossIncome { get; set; }

        public int IncomeTax { get; set; }

        public int NetIncome { get; set; }


        public void GetData()
        {
            

            Console.WriteLine("Please enter the value for Id");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the value for Name");
            Name = Console.ReadLine();

            Console.WriteLine("Please enter value for Gross Income");
            GrossIncome = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter value for IncomeTax");
            IncomeTax = Convert.ToInt32(Console.ReadLine());

            NetIncome = CalculateNetIncome();

            
        }

        public void PutData()
        {
            Console.WriteLine("Id = " + Id);
            Console.WriteLine("Name = " + Name);
            Console.WriteLine("GrossIncome = " + GrossIncome);
            Console.WriteLine("IncomeTax = " + IncomeTax);
            Console.WriteLine("NetIncome = " + NetIncome);
        }

        public int CalculateNetIncome()
        {
            int result = GrossIncome - IncomeTax;
            return result;
        }

        ///////// OR //////////

        public static void GetData1()
        {
            Doctors doc1 = new Doctors(); 

            Console.WriteLine("Please enter the value for Id");
            doc1.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the value for Name");
            doc1.Name = Console.ReadLine();

            Console.WriteLine("Please enter value for Gross Income");
            doc1.GrossIncome = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter value for IncomeTax");
            doc1.IncomeTax = Convert.ToInt32(Console.ReadLine());

            doc1.NetIncome = doc1.CalculateNetIncome1();

            doc1.PutData1();
        }

        public void PutData1()
        {
            Console.WriteLine("Id = " + Id);
            Console.WriteLine("Name = " + Name);
            Console.WriteLine("GrossIncome = " + GrossIncome);
            Console.WriteLine("IncomeTax = " + IncomeTax);
            Console.WriteLine("NetIncome = " + NetIncome);
        }

        public int CalculateNetIncome1()
        {
            int result = GrossIncome - IncomeTax;
            return result;
        }

    }
}
