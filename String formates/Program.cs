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

        //   *Suraj*

        Console.WriteLine("*Suraj*");

        //    "Suraj"

        Console.WriteLine("\"Suraj\"");
        Console.WriteLine("I am \tBest  \"Employee\" in our \noffice");

        Console.WriteLine("https://www.canva.com/design/DAF5Rjo0xDA/KBWK9BiziIDTdRCZF39hxQ/edit");

        Console.WriteLine("C:\\Users\\addld\\AppData\\Local\\Temp\\{962C0941-2823-4BE6-9D5B-B131DC56803B}\\{AED3B0E9-E18C-4F84-BC40-63209FC301D7}");

        Console.WriteLine(@"C:\Users\addld\AppData\Local\Temp\{962C0941-2823-4BE6-9D5B-B131DC56803B}\{AED3B0E9-E18C-4F84-BC40-63209FC301D7}");

        string email = "gaurav@gmail.com";
        Console.WriteLine(email);
        Console.WriteLine(email.Substring(0,5));
        Console.WriteLine(email.Substring(0,10));
        Console.WriteLine(email.Substring(0,email.IndexOf('@')));
        Console.WriteLine(email.Substring(email.IndexOf('@')+1, email.Length-email.IndexOf('@')-1));


        Console.ReadLine();
    }
}