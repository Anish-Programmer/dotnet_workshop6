namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -------------------- 1. SELECT / PROJECTION --------------------
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            var squaredNumbers = numbers.Select(n => n * n).ToList(); // --using LINQ Select to square each number

            Console.WriteLine("Squared Numbers:");
            foreach (var sq in squaredNumbers)
            {
                Console.WriteLine(sq);
            }
                

            // -------------------- 2. FILTERING (WHERE) --------------------
            List<Book> books = new List<Book> //---list of book objects
            {
                new Book { Title="C# Basics", Price=500 },
                new Book { Title="Advanced .NET", Price=1500 },
                new Book { Title="Data Structures", Price=1200 },
                new Book { Title="Story Book", Price=300 }
            };

            var premiumBooks = books.Where(b => b.Price > 1000).ToList();

            Console.WriteLine("\nBooks priced above Rs.1000:");
            foreach (var book in premiumBooks)
                Console.WriteLine($"{book.Title} - Rs.{book.Price}");


            // -------------------- 3. SORTING (OrderBy) --------------------
            List<Student> students = new List<Student> //---list of student objects
            {
                new Student { Name="Anish" },
                new Student { Name="Bikash" },
                new Student { Name="Arjun" },
                new Student { Name="Nikita" },
                new Student { Name="Pramisha" },
                new Student { Name="Laxman" },
                new Student { Name="Dilip" },
                new Student { Name="Aayush" },
                new Student { Name="Sujan" },
                new Student { Name="Kritika" }
            };

            var sortedStudents = students.OrderBy(s => s.Name).ToList();

            Console.WriteLine("\nStudents Sorted Alphabetically for AAA:");
            foreach (var s in sortedStudents)
            {
                Console.WriteLine(s.Name);
            }
           

            Console.ReadLine();
        }
    }

}
