namespace TutorialTasks
{
    internal class Program
    {
        // Method 1: To take a parameter and perform an action
        public static void Greet(string name)
        {
            Console.WriteLine("Welcome, " + name + "!");
        }


        // Method 2: Product method
        public static int Product(int x, int y)
        {
            return x * y;
        }

        // Method 3: To implement try...catch
        public static void CatchErr()
        {
            Console.WriteLine("Enter a number:");
            try
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(num + " plus 10 is: " + (num + 10));
            }
            catch (Exception)
            {
                Console.WriteLine("Kindly enter only numbers!");
            }

        }
  





        // Main
        static void Main(string[] args)
        {
            Console.WriteLine("Hi there! What is your name?: ");
            string userName = Console.ReadLine();
            Greet(userName);
            Console.WriteLine("3 X 5 is : " + Product(3, 5));
            CatchErr();
            
        }

    }
}