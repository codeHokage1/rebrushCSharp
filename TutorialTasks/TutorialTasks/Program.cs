namespace TutorialTasks
{
    internal class Program
    {
        // Method 1: To take a parameter and perform an action
        public static void Greet(string name)
        {
            Console.WriteLine("Hello there, " + name + "!");
        }


        // Method 2: Product method
        public static int Product(int x, int y)
        {
            return x * y;
        }



        // Main
        static void Main(string[] args)
        {
            Greet("Farhan");
            Console.WriteLine("3 X 5 is : " + Product(3, 5));
        }

    }
}