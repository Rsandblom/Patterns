using System;
using System.Collections.Generic;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Product Report!");

            var products = new List<Product>
            {
            new Product { Ref = "17176", LotNr = "038001", Quantity = 600 },
            new Product { Ref = "17130", LotNr = "038002", Quantity = 600 },
            new Product { Ref = "17178", LotNr = "038003", Quantity = 300}
            };

            var builder = new ProductReportBuilder(products);
            var director = new ProductReportDirector(builder);

            //director.BuildSimpleReport();
            director.BuildFullReport();

            var report = builder.GetReport();
            Console.WriteLine(report);
            Console.ReadLine();
        }
    }
}
  
