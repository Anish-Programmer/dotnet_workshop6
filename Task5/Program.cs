using System;
using System.Collections.Generic;
using System.Linq;

namespace Task5
{
    internal class Program
    {
        static void Main()
        {
            AggregationDemo();   // total / highest / lowest / average
            QuantifierDemo();    // Any / All age checks
            ElementDemo();       // First / Last / FirstOrDefault

            Console.ReadLine();
        }

        /* ---------- 1.  AGGREGATION Operator ---------- */
        static void AggregationDemo()
        {
            var sales = new List<CashierSales>
            {
                new CashierSales{ CashierId=101, SaleAmount=4500m },
                new CashierSales{ CashierId=102, SaleAmount=7200m },
                new CashierSales{ CashierId=103, SaleAmount=3800m },
                new CashierSales{ CashierId=104, SaleAmount=9100m },
                new CashierSales{ CashierId=105, SaleAmount=5600m }
            };

            Console.WriteLine("-----Aggregation Operators-----");
            Console.WriteLine($"Total cashiers : {sales.Count}");
            Console.WriteLine($"Total sales    : Rs.{sales.Sum(s => s.SaleAmount)}");
            Console.WriteLine($"Highest sale   : Rs.{sales.Max(s => s.SaleAmount)}");
            Console.WriteLine($"Lowest sale    : Rs.{sales.Min(s => s.SaleAmount)}");
            Console.WriteLine($"Average sale   : Rs.{sales.Average(s => s.SaleAmount):F2}\n");
        }

        /* ---------- 2.  QUANTIFIER Operator ---------- */
        static void QuantifierDemo()
        {
            var applicants = new List<Applicant>
            {
                new Applicant{Name="Ramesh", Age=17 },
                new Applicant{Name="Sita",   Age=19 },
                new Applicant{Name="Hari",   Age=22 },
                new Applicant{Name="Geeta",  Age=16 }
            };

            Console.WriteLine("------Quantifier Operators----");
            Console.WriteLine($"Any applicant under 18 ? : {applicants.Any(a => a.Age < 18)}");
            Console.WriteLine($"Every applicant above 16 ? : {applicants.All(a => a.Age > 16)}\n");
        }

        /* ---------- 3.  ELEMENT Operators ---------- */
        static void ElementDemo()
        {
            var songs = new List<Song>
            {
                new Song{Title="Intro",    DurationSec=95  }, // 1:35 
                new Song{Title="BeatDrop", DurationSec=210 }, // 3:30
                new Song{Title="Chorus",   DurationSec=255 }, // 4:15
                new Song{Title="Bridge",   DurationSec=320 }, // 5:20
                new Song{Title="Outro",    DurationSec=430 }  // 7:10
            };

            Console.WriteLine("----- Element Operators ----");
            Console.WriteLine($"First song           : {songs.First().Title}");
            Console.WriteLine($"Last song            : {songs.Last().Title}");
            Console.WriteLine($"First > 4 min        : {songs.First(s => s.DurationSec > 240).Title}");

            // Safe lookup – returns null if none satisfies the condition
            var longSong = songs.FirstOrDefault(s => s.DurationSec > 600);
            Console.WriteLine($"First > 10 min       : {longSong?.Title ?? "none"}");
        }


    }
}