#region default interface method implementation

//IA a = new A();
//a.Print();


//Console.ReadLine();

//interface IA
//{
//    public void Print()
//    {
//        Console.WriteLine("IA Print()");
//    }
//}

//public class A : IA
//{
//    public void Print()
//    {
//        Console.WriteLine("A Print()");
//    }
//}

#endregion default interface method implementation

Student s1 = new Student();
s1.Insert();

Customer c1 = new Customer();
c1.Print();
c1.Display();


Console.ReadLine();

public partial class Customer
{
  public partial void Print(); // Declartion // Incomplete method

   public  partial void Print() // implimention // complete method
    {
        Console.WriteLine("Customer Print()");
    }
    public partial void Display();
   public partial void Display() // implimention // complete method
    {
        Console.WriteLine("Customer Print()");
    }
}