class Program
{
    static void Main()
    {
        A a1 = new A();
        a1.Print(); // A

        B b1 = new B();
        b1.Print(); // B

        Console.WriteLine("************\n");

        A a2 = new B();
        a2.Print(); // A

        Console.WriteLine("****************\n");

        A a3 = new A();
        // A a2 = new B();
        Console.WriteLine("****************\n");
        B b3 = new B();

        Console.WriteLine("***************************");

      //  A a4 = new A("XYZ");
        B b4 = new B("XYZ");

        Console.ReadLine();
    }
}

class A
{
    public string Name = "G#";

    public A()
    {
        Console.WriteLine("A()");
    }

    public void Print()
    {
        Console.WriteLine("A");
    }

    public A(string s)
    {
        Console.WriteLine("A(string s)");
        Console.WriteLine(Name);
    }
}

class B : A
{
    public string Name = "G# TECH";

    public B()
    {
        Console.WriteLine("B()");
    }

    public B(string s) : base(s)
    {
        Console.WriteLine("B(string s)");
        Console.WriteLine(Name);
        Console.WriteLine(base.Name); // it will access base class Name value
    }

    //method hiding
    new public void Print()
    {
        Console.WriteLine("B");
    }
}