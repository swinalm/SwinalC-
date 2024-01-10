//class program
//{
//    static void Main()
//    {
//        Console.WriteLine("abcdefg");
//    }
//}

//Console.WriteLine("abcdefg");

class Program
{
    static void Main()
    {

        string a = "123", b = "*****+++++++++=========", c = "Gaurav Shahare";
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(c.ToLower()); // Lower Case
        Console.WriteLine(c.ToUpper()); // Upper Case



        string firstName = "Salman", lastName = "Khan";
        Console.WriteLine(firstName); //
        Console.WriteLine(lastName); //
        Console.WriteLine(lastName.Length);

        string fullName = firstName + lastName;
        Console.WriteLine(fullName);

        fullName = string.Concat(firstName, " ", lastName);
        Console.WriteLine(fullName);

        fullName = string.Join("-", firstName, lastName);
        Console.WriteLine(fullName);


        //   FullName: Salman Khan

        Console.WriteLine("FullName :" + firstName + lastName);
        fullName = "FullName :" + firstName + " " + lastName;
        Console.WriteLine(fullName);

        // String Interpollution

        Console.WriteLine($"FullName : {firstName} {lastName}");

        fullName = $"FullName : {firstName} {lastName}";
        Console.WriteLine(fullName);

        int i1 = firstName.IndexOf('m');
        int i2 = lastName.IndexOf('h');
        Console.WriteLine(i1);
        Console.WriteLine($"{firstName} : m - {i1}  {lastName} : h - {i2}");

        Console.ReadLine();
    }
}