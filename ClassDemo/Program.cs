class Program
{
    static void Main()
    {
        int rn = 1;
        string name = "Ramesh";
        string gender = "Male";
        long mobile = 8956890522;

        // Student s1; // null

        Student s1 = new Student(); // object / instance
        // reading: s1 is a reference variable of type Student pointing to
        // Student Object

        s1.FirstName = "Ramesh";
        s1.LastName = "Yadav";
        s1.PrintFullName();

        Student s3 = new Student();
        s3.FirstName = "Tom";
        s3.LastName = "Jerry";
        s3.PrintFullName();


        Student s5 = new Student()
        {
            FirstName = "salman",
            LastName = "Khan"
        };
        s5.PrintFullName();




        Employee employee = new Employee();
        employee.Emp_id = 1001;
        employee.Name = "Ranvir";
        employee.Gender = "Male";

        employee.information();

        Employee e1 = new Employee()
        {
            Emp_id = 1002,
            Gender = "Female",
            Name = "Gaytri"
        };
        e1.information();


        Employee swinal = new Employee()
        {
            Emp_id = 1003,
            Name = "Nikhil",
            Gender = "Male"
        };

        swinal.information();












        Student s2 = new Student();
        s2.FirstName = "Ritesh";
        s2.LastName = "Jadhav";
        s2.PrintFullName();

        // object initializer syntax
        Student s4 = new Student()
        {
            FirstName = "Paresh",
            LastName = "Desale"
        };
        s4.PrintFullName();

        Circle.Pi = 3.14f;

        Circle c1 = new Circle();
        c1.Radius = 5;
        // c1.Pi = 3.14f;
        c1.Area();

        // Circle c2 = new Circle() { Radius = 10, Pi = 3.14f};
        Circle c2 = new Circle() { Radius = 10 };
        c2.Area();

        Console.ReadLine();
    }
}

public class Student
{
    // fields 
    // global variable can be used anywhere inside class
    public string FirstName;
    public string LastName;

    // method
    public void PrintFullName()
    {
        Console.WriteLine($"Full Name : {FirstName} {LastName}");
    }
}

public class Circle
{
    public int Radius;
    public static float Pi;

    public void Area()
    {
        Console.WriteLine($"Area : {Pi * Radius * Radius} of a circle having radius : {Radius} ");
    }
}


public class Employee
{
    public string Name;
    public int Emp_id;
    public string Gender;

    public void information()
    {
        Console.WriteLine($"Employee id : {Emp_id}\nName : {Name}\nGender :{Gender} ");
    }
}