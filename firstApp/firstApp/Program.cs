// ## Using the normal C# structure

//public class firstApp
//{
//    public static void Main()
//    {
//        string name = "Farhan Sodiq";
//        float weight = 80.05f;

//        Console.WriteLine("Welcome " + name);
//        Console.WriteLine("Your weight plus 10kg is " + (weight + 10));
//    }
//}






// ## Using only top-level statements
//string name = "Farhan Sodiq";
//float weight = 80.05f;
//float newWeight = weight + 10;

//var x = "Hello there";

//Console.WriteLine("Welcome " + name);
//Console.WriteLine("Your weight plus 10kg is " + (weight + 10));



public class firstApp
{
    /// <summary>
    /// First Task: To swap two numbers
    /// </summary>
    public static void Main()
    {
        int a = 5;
        int b = 20;

        // logic
        int temp = a;
        a = b;
        b = temp;

        // result
        Console.WriteLine("a is " + a + " and b is " + b);
    }
}