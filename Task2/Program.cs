namespace Task2
{
    
    // Delegate that takes two ints and returns an int
    public delegate int Calculate(int a, int b);

    // Delegate for discount strategy
    public delegate double DiscountStrategy(double price);

    internal class Program
    {
        static void Main(string[] args)
        {
            // Methods for Calculate delegate
            static int Add(int x, int y) => x + y;
            static int Subtract(int x, int y) => x - y;

            // Methods for DiscountStrategy delegate
            static double FestivalDiscount(double price) => price * 0.80;
            static double SeasonalDiscount(double price) => price * 0.90;
            static double NoDiscount(double price) => price;

            //----creating delegate instance for Calculate--------
            Calculate add = Add;
            Calculate subtract = Subtract;

            Console.WriteLine("------Calculate Delegate-----");
            Console.WriteLine($"Add(10, 5) = {add(10, 5)}");
            Console.WriteLine($"Subtract(10, 5) = {subtract(10, 5)}");
            

            //------------------instamce of DiscountStrategy Delegate------------------
            DiscountStrategy festival = FestivalDiscount;
            DiscountStrategy seasonal = SeasonalDiscount;
            DiscountStrategy noDiscount = NoDiscount;

            
            double price = 1000;

            Console.WriteLine("\n-----DiscountStrategy Delegate-----");
            Console.WriteLine($"Original Price: {price}");
            Console.WriteLine($"Festival Discount (20% off): {festival(price)}");
            Console.WriteLine($"Seasonal Discount (10% off): {seasonal(price)}");
            Console.WriteLine($"No Discount: {noDiscount(price)}");

            Console.ReadLine();
        }

    }
}
