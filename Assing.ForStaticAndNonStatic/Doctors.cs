using System;
using System.Collections.Generic;
using System.Linq;
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
            GrossIncome= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter value for IncomeTax");
            IncomeTax= Convert.ToInt32(Console.ReadLine());

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
    }
}
