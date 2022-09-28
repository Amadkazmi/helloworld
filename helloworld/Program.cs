internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello this is first github!");

        string name, surname;
        int age;
        Console.WriteLine("Enter your name:");
        name = Console.ReadLine();

        Console.WriteLine("Enter your surname:");
        surname = Console.ReadLine();
        
        Console.WriteLine("Enter your age:");
        age = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("hello!");
        Console.WriteLine("Your name is {0}, your surname is {1}, your age is {2}", name, surname, age);

        


    }
}
