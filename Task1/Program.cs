namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating an object of Rectangle class
            Rectangle rect = new Rectangle(10, 5);
            
            
            Console.WriteLine(rect.ShowDetails());
            Console.WriteLine($"Area: {rect.GetArea()}");
            Console.WriteLine($"Perimeter: {rect.GetPerimeter()}");

            Console.ReadLine();
        }
    }
}
