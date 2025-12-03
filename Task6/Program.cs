using System;
using System.Collections.Generic;
using System.Linq;

namespace TravelCompanyReport
{
    internal class Program
    {
        private static void Main()
        {
            var bookings = new List<Booking>
            {
                new Booking { CustomerName = "Sujan",  Destination = "Pokhara",     Price = 12000, DurationInDay = 5, IsInternational = false },
                new Booking { CustomerName = "Alisha", Destination = "Paris",       Price = 85000, DurationInDay = 8, IsInternational = true  },
                new Booking { CustomerName = "Bikash", Destination = "Kathmandu",   Price =  9000, DurationInDay = 3, IsInternational = false },
                new Booking { CustomerName = "Nikita", Destination = "Dubai",       Price = 45000, DurationInDay = 6, IsInternational = true  },
                new Booking { CustomerName = "Ramesh", Destination = "Chitwan",     Price = 11000, DurationInDay = 5, IsInternational = false },
                new Booking { CustomerName = "Sita",   Destination = "Kerala",      Price = 25000, DurationInDay = 7, IsInternational = true  }
            };

            // 1. Filter   2. Project (keep Price)   3. Sort
            var summary = bookings
                .Where(b => b.Price > 10_000 && b.DurationInDay > 4)
                .Select(b => new
                {
                    b.CustomerName,
                    b.Destination,
                    Category = b.IsInternational ? "International" : "Domestic",
                    b.Price       // added so ThenBy(x => x.Price) compiles
                })
                .OrderBy(x => x.Category)
                .ThenBy(x => x.Price);

            // 4. Display
            Console.WriteLine("Filtered & Sorted Tour Summary");
            Console.WriteLine("--------------------------------------------------");
            foreach (var item in summary)
            {
                Console.WriteLine($"{item.CustomerName,-10} | {item.Destination,-12} | {item.Category,-13} | Rs.{item.Price}");
            }
            Console.WriteLine("--------------------------------------------------");

            Console.ReadLine();
        }
    }

    /* ----------Booking class ---------- */
    internal class Booking
    {
        public string CustomerName { get; set; } = null!;
        public string Destination { get; set; } = null!;
        public decimal Price { get; set; }
        public int DurationInDay { get; set; }
        public bool IsInternational { get; set; }
    }
}