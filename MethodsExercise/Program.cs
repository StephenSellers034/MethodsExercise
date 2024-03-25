namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("Who is your favorite band?");
            string band = Console.ReadLine();
            Console.WriteLine($"Hello, {name}. My name is Stephen. What is your favorite color? {color}. I love the color Blue. My favorite animal is a dog. Whats Your favorite animal? {animal}. I like the Rolling Stones. Who is your favorite band? {band}.");
            int y = Add(10,5,12,14,34);
            Console.WriteLine(y);
            Subtract(10, 5);
            Multiply(10, 5);
            Divide(10, 5);
        }

        public static void PrintsYourName()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello,{name}");
        }

        public static void PrintsYourFavoriteColor()
        {
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine($" My favorite color is {color}");
        }

        public static void PrintsYourFavoriteAnimial()
        {
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine($"My Favorite animal is {animal}");
        }

        public static void PrintsYourFavoriteBand()
        {
            Console.WriteLine("Who is your favorite band?");
            string band = Console.ReadLine();
            Console.WriteLine($"My favorite Band is {band}");
        }

        public static int Add(params int[] ListNumbers)
        {
            int total = 0;
            foreach (int i in ListNumbers)
            {
                total += i;
            }
            return total;
        }

        public static int Subtract(int numb1, int numb2)
        {
            int Difference = numb1 - numb2;
            Console.WriteLine(Difference);
            return Difference;
        }

        public static int Multiply(int numb1, int numb2)
        {
            int Product = numb1 * numb2;
            Console.WriteLine(Product);
            return Product;
        }

        public static int Divide(int numb1, int numb2)
        {
            int Quotient = numb1 / numb2;
            Console.WriteLine(Quotient);
            return Quotient;
        }
    }

}
