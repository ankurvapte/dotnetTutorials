namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine("What is your surname?");
            var surname = Console.ReadLine();
            
            /* 
             * Following style of string representation is called interpolated string 
             */

            Console.WriteLine($"{Environment.NewLine}Hello, {name} {surname}, on {currentDate:d} at {currentDate:t}!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}