namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            MadLib();
            Add(24, 36, 52, 4, 19);
            Subtract(95, 77);
            Multiply(34, 7);
            Divide(99, 11);
            Modulus(49, 5);
        }

        public static void MadLib()
        {
            Console.WriteLine("What is your last name?");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("How was your day?");
            string how = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Do you jog,walk, or run a mile?");
            string exercise = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"One {how} day with a woof and a purr.\n" +
                $"A {name} was born and it caused a little stir.\n" +
                $"No blue buzzard, no three -eyed frog.\n" +
                $" Just a feline canine little {animal}dog.\n " +
                $"{animal}dog, {animal}dog, alone in the world is a little {animal}dog!\n" +
                $" Out on the road or back in town.\n " +
                $"All kinda critter putting {animal}dog down.\n" +
                $" Gotta rise above it gotta try to get along.\n " +
                $"Gotta {exercise} together gotta sing this song.\n" +
                $" {animal}dog, {animal}dog, alone in the world is a little {animal}dog!");
         }
        public static int Add(params int[] list)
        {
            int sum = 0;
            foreach(int i in list)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
            return sum;
        }

        public static int Subtract(int n1, int n2)
        {
            int difference = n1 - n2;
            Console.WriteLine(difference);
            return difference;

        }

        public static int Multiply(int n1, int n2)
        {
            int product = n1 * n2;
            Console.WriteLine(product);
            return product;
        }

        public static int Divide(int n1, int n2)
        {
            int quotient = n1 / n2;
            Console.WriteLine(quotient);
            return quotient;
        }

        public static int Modulus(int n1, int n2)
        {
            int modulus = n1 % n2;
            Console.WriteLine(modulus);
            return modulus;
        }


    }
}

    


