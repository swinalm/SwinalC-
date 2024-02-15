//using _20_namespaces.bank;
//using _20_namespaces.school; // import namespaces
//// using Batch20;
using B20 = VhaashTech.Training.Batch20;
using Batch21;
using Cinema;
using System.Security.Principal;
// using Cinema;

using Namespace_Example.Bank;
using Namespace_Example.School;

class Program
{
    static void Main()
    {
        Student s1 = new Student();
        s1.Print();

        Account a1 = new Account();
        a1.Print();

        // Cinema.Customer c1 = new Cinema.Customer();
        //Customer c1 = new Customer();

        Cinema.Customer c1 = new Cinema.Customer();
        c1.Print();

        Session b2 = new Session(); // ambiguity / confusion
        b2.Print();
        //Batch20.Session b1 = new Batch20.Session();
        //VhaashTech.Training.Batch20.Session b1 =
        //    new VhaashTech.Training.Batch20.Session();
        //b1.Print();
        B20.Session b1 = new B20.Session();
        b1.Print();

        //Letter l1 = new Letter();
        //l1.Print();

        Console.ReadLine();
    }
}

# region without namespace
//public class Customer // default namespace = root namespace
//{
//    public void Print()
//    {
//        Console.WriteLine("Customer Print() method");
//    }
//}
#endregion without namespace

#region with namespace

namespace Cinema
{
    public class Customer // default namespace = root namespace
    {
        public void Print()
        {
            Console.WriteLine("Customer Print() method");
        }
    }
}

#endregion with namespace

namespace VhaashTech.Training.Batch20
{
    public class Session
    {
        public void Print()
        {
            Console.WriteLine("Batch20 Session Print() Method");
        }
    }
}

namespace Batch21
{
    public class Session
    {
        public void Print()
        {
            Console.WriteLine("Batch21 Session Print() Method");
        }
    }

    public class Letter
    {
        public void Print()
        {
            Console.WriteLine("Batch21 Letter Print() Method");
        }
    }
}