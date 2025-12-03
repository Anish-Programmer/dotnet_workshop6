namespace Task2._1
{
    // Delegate for discount strategy   
    public delegate double DiscountStrategy(double price);

    internal class Program
    {
        static void Main(string[] args)
        {
            double price = 1000;

            // Calling using different discount strategies 
            Console.WriteLine("-----Using Discount Strategy Methods------");
            Console.WriteLine($"Festival Discount (20%): {CalculateFinalPrice(price, FestivalDiscount)}");
            Console.WriteLine($"Seasonal Discount (10%): {CalculateFinalPrice(price, SeasonalDiscount)}");
            Console.WriteLine($"No Discount: {CalculateFinalPrice(price, NoDiscount)}");

            // Calling using lambda 
            Console.WriteLine("\n-----Using Lambda Expression (30% Discount)-------");
            Console.WriteLine($"30% Discount: {CalculateFinalPrice(price, p => p * 0.70)}");

            Console.ReadLine();
        }

        
        // Method that accepts original price + delegate
        public static double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy)
        {
            return strategy(originalPrice);
        }

        // ---------------- Discount Methods ----------------
        static double FestivalDiscount(double price) => price * 0.80;  // 20% off
        static double SeasonalDiscount(double price) => price * 0.90;  // 10% off
        static double NoDiscount(double price) => price;               // no discount
    }
}
