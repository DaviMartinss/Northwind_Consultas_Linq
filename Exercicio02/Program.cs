using System;
using static System.Console;
using Packt.Shared;
using System.Linq;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new Northwind())
            {

                var Todas_cidades_diferentes = db.Customers.ToList()
                    .Select(c => c.City)
                    .Distinct()
                    .OrderBy(c => c);

                WriteLine($"{string.Join(", ", Todas_cidades_diferentes)}");
                
                WriteLine();

                Write("Informe o nome de uma cidade: ");
                var cidade = ReadLine();

                var query = db.Customers
                    .Where(c => c.City == cidade);
                    
                
                WriteLine($"Existem {query.Count()} clientes em {cidade}:");
                foreach (var item in query)
                {
                    WriteLine($"{item.CompanyName}");
                }
            } 
        }
    }
}
