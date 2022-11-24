using P03.Detail_Printer;
using System;
using System.Collections.Generic;

namespace P03.DetailPrinter
{
    class Program
    {
        static void Main()
        {
            IEmployee employee = new Employee("Gosho");
            IEmployee manager = new Manager("Mitko", new List<string>() {"Doc1", "Doc2" });

            DetailsPrinter detailPrinter = new DetailsPrinter(new List<IEmployee>() { employee,manager});

            detailPrinter.PrintDetails();
        }
    }
}
