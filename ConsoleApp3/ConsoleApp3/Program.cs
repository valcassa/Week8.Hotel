using System;
using System.Linq; 
using Week6.EF;

//Tools>Nuget
// Add-Migration firstMigration
// Update-database 

namespace ConsoleApp3
{
    class Program
    {
        private static KnightsContext _knightsContext = new KnightsContext();

        static void Main(string[] args)
        {
            _knightsContext.Database.EnsureCreated();

         }

        private static void FetchKnights()
        {
            var knights = _knightsContext.Knights.ToList();
            Console.WriteLine($"Il numero di cavalieri è: {knights.Count}");

            foreach(var k in knights)
            {
                Console.WriteLine(k.Name);

            }
        }
    }
}
