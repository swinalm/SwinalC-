using ClassGvrv;

class Program
{
    static void Main()
    {
        Console.WriteLine("Main Program start");
        Student s1 = new Student();
        s1.Display(101, "Nayan", "Male");

        Console.WriteLine("_________________________________________________________");

        Trainer T1 = new Trainer();
        T1.Id = 1;
        T1.Name = "Vivek";
        T1.Gender = "Male";
        T1.View();

        Console.WriteLine("************************************************************");
        Trainer T2 = new Trainer()
        {
            Id = 2,
            Name = "Kashish",
            Gender = "Female"

        };
        T2.View();

        Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        Gaurav g1 = new Gaurav();
        g1.Empid = 1111;
        g1.Name = "Ajmal";
        g1.Salary = "100000";

        g1.Show();

        Console.ReadLine();
    }
}



class Student
{
    //public int Rollnumber;
    //public string Name;
    //public string Gender;

    public void Display(int _Rollnumber, string _Name, string _Gender)
    {
        Console.WriteLine($"RollNumber {_Rollnumber}\n Name {_Name}\n Gender {_Gender}");
    }
}

class Trainer
{
    public int Id;
    public string Name;
    public string Gender;

    public void View()
    {
        Console.WriteLine($"ID {Id}\n Name {Name}\n Gender {Gender}");
    }
}