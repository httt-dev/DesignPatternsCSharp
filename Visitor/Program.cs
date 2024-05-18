using System;
using System.Collections.Generic;

namespace Visitor
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var employees = new List<IElement>
            {
                new BackOfficeEmployee("A", 80000, 10000),
                new BackOfficeEmployee("B", 120000, 10000),
                new SaleEmployee("C", 90000, 40000),
            };

            var compensationVisitor = new CompensationVisitor();
            employees.ForEach(e => e.Accept(compensationVisitor));
            Console.WriteLine($"Total compensation {compensationVisitor.TotalCompensation:C}");

            var stockVisitor = new EmployeeStockOptionVisitor();
            employees.ForEach(e => e.Accept(stockVisitor));
            
            Console.WriteLine($"Total stock options : {stockVisitor.TotalUnit}");
        }
    }
}