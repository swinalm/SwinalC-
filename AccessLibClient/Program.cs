using AccessLib;



// Client Assembly

Al1 a1 = new Al1(); // inside library
a1.Print();
// a1.PrintA();

// AL2 a2 = new AL2();

AL3 a3 = new AL3();
a3.Print();



static void Main()
{
    AL a = new AL();
    a.PrintA();

    Console.ReadLine();
}

class AC2 : Al1
{
    public void Print()
    {
        base.Print(); // public
        base.PrintB(); // protected
        // base.PrintA(); // it is private
        base.PrintC(); // another assembly => protected
    }
}

class AC1
{
    public void Print()
    {
        Al1 a1 = new Al1();
        a1.Print(); // public
        //a1.PrintA(); // private
        //a1.PrintB(); // protected
        //a1.PrintC(); // protected internal
    }
}