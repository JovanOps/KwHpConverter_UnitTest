namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            double result = 0;

            Console.WriteLine("Please, enter value: ");
            double value = double.Parse(Console.ReadLine());

            Console.WriteLine("Convert to (enter kw or hp):");
            string convertTo = Console.ReadLine();

            if (convertTo == "kw")
            {
                result = KwHpConverter(value, "kw");
            }
            else
            {

                result = KwHpConverter(value, "hp");
            }

            Console.WriteLine(result);
        }

        public static double KwHpConverter(double inputValue, string convertTo)
        {
            if (convertTo == "hp")
            {
                return inputValue / 0.745699872;
            }
            else
            {
                return inputValue * 0.745699872;
            }
        }
    }
}
