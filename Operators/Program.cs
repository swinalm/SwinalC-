class Program
{
    static void Main()
    {
        int a = 1;
        Console.WriteLine(a);  // 1
        Console.WriteLine("a");  // a
        Console.WriteLine('a'); // a

       int b = 10;
        Console.WriteLine(b==a); // False
        Console.WriteLine(b != a); //true
        Console.WriteLine(a<b); // true
        Console.WriteLine(b<a); // false
        Console.WriteLine(a<=b); // true
        Console.WriteLine(a>=b); // false

        Console.WriteLine(a+b); // 11
        Console.WriteLine(a - b); // -9
        Console.WriteLine(a * b); // 10
        Console.WriteLine(4 / 2); // 2
        Console.WriteLine(a % b); // 1
        Console.WriteLine("****************************************");
        Console.WriteLine(a+=a);
        Console.WriteLine(a -= a);
        Console.WriteLine(a *= a);
    //    Console.WriteLine(a /= a);
        Console.WriteLine("******************************************");
        int w = 10;
        Console.WriteLine(w);
        Console.WriteLine(w++);
        Console.WriteLine(w);
        Console.WriteLine(++w);
        Console.WriteLine(w);
        Console.WriteLine(--w);
        Console.WriteLine(w);
        Console.WriteLine(w--);
        Console.WriteLine(w);

        Console.WriteLine("____________**********____________");
        Console.WriteLine(10>5 && 50<10);
        Console.WriteLine(50 < 10 || 60 > 5);










        //•	=
        //•	==, !=, <, <=, >, >=
        //•	+,-,*,/,%
        //•	&&,||
        //•	+=,-=,*=,/=
        //•	++,--






        Console.ReadLine();
    }
}