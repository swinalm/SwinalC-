using ConstructorDemo;

class Program
{
    static void Main()
    {
        Student s1 = new Student();
        s1.FirstName = "Vishal";
        s1.LastName = "Ade";
        Student.CourseName = "Java";
        s1.Print(); // Full Name: Vishal Ade

        Console.WriteLine("__________________________________________");

        Student s2 = new Student() { FirstName = "Atul", LastName = "Rathod" };
        s2.Print(); // Full Name: Atul Rathod

        Console.WriteLine("____________________________________");

        Student s3 = new Student();
        s3.Initialize("Ajay", "Chavhan");
        s3.Print(); // Full Name: Ajay Chavhan

        Console.WriteLine("________________________________________");

        Student s4 = new Student();
        s4.Print(); // Full Name: 

        Console.WriteLine("________________________________________");

        Student s5 = new Student("Mohan", "Das");
        s5.Print(); // Full Name: Mohan Das

        Console.WriteLine("________________________________________");

        Student s6 = new Student(s5); // s6 = s5;
        s6.Print(); // Full Name: Mohan Das

        // Customer c1 = new Customer();
        // Customer c2 = new Customer();
        // Customer c3 = new Customer();

        // Customer c1 = new Customer();
        //Console.WriteLine(Customer.Site);
        Console.ReadLine();
    }
}
class Customer
{
    public static string Site;

    public Customer()
    {
        Console.WriteLine("default constructor called");
    }

    static Customer()
    {
        Site = "Flipkart";
        Console.WriteLine("static constructor called");
    }
}

