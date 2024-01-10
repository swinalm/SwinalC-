class Program
{
    static void Main()
    {
        byte b = 2;
        Console.WriteLine("Byte");
        Console.WriteLine("Size of Byte" + sizeof(byte));
        Console.WriteLine("Minimum Value of Byte" + byte.MinValue);
        Console.WriteLine("Maximum Value of Byte" + byte.MaxValue);
        Console.WriteLine("************************************************************");

        short s = 10;
        Console.WriteLine("Short");
        Console.WriteLine(sizeof(short));
        Console.WriteLine(short.MinValue);
        Console.WriteLine(short.MaxValue);
        Console.WriteLine("*************************************************************");

        int i = 1000;
        
        Console.WriteLine("Int");
        Console.WriteLine(sizeof(int));
        Console.WriteLine(short.MinValue);
        Console.WriteLine(short.MaxValue);
        Console.WriteLine("************************************************************");
       
        
        
        
        Console.WriteLine(sizeof(long));
        Console.WriteLine("*******************************************************************");

        float f = 22.3f;
        double d = 333.4;
        decimal c = 234.4m;

        Console.WriteLine(sizeof(float));   
        Console.WriteLine(float.MinValue);
        Console.WriteLine(float.MaxValue);

        Console.WriteLine(sizeof(double));
        Console.WriteLine(double.MinValue);
        Console.WriteLine(double.MaxValue);


        Console.WriteLine(sizeof(decimal));
        Console.WriteLine(decimal.MinValue);
        Console.WriteLine(decimal.MaxValue);
        Console.WriteLine("************************************");

        bool g = true;
        bool h=false;

        Console.WriteLine(sizeof (bool));
       
        Console.WriteLine("********************************************");

        char p= 'a';
        Console.WriteLine(sizeof (char));
        Console.WriteLine(char.MinValue);
        Console.WriteLine(char.MaxValue);

        Console.WriteLine("**************************************************");

        string abc = "Ajmal";
        //Console.WriteLine(sizeof(String));

        Console.ReadLine();
    }
}

