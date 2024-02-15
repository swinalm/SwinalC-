using Calucations;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Client 1 Project");

        Calculator c1 = new Calculator();
        int result = c1.Add(10, 10);
        Console.WriteLine($"Addition : {result}");

        result = c1.Division(150, 10);
        Console.WriteLine($"Division : {result}");

        Console.ReadLine();
    }
}