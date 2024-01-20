#region without array

//string name1 = "Ramesh";
//Console.WriteLine(name1);

//string name2 = "Prithvi";
//Console.WriteLine(name2);

//string name3 = "Kunal";
//Console.WriteLine(name3);


//string name4 = "raj", name5 = "rakesh", name6 = "toushik";
//Console.WriteLine(name4 +"\n"+ name5 +"\n"+ name6);




#endregion without array

#region array

//string name = "Ramesh";

//string[] names = new string[]; // not possible



//int[] abc = new int[2];

//abc[0] = 1;
//abc[1] = 2;
////abc[2] = 3;
////abc[3] = 4;
////abc[4] = 5;


//Console.WriteLine(abc[1]);










//string[] names = new string[3];
//names[0] = "Ramesh";
////names[0] = 10; // array is type safe, same type element it allows
//names[1] = "Pritvi";
//names[2] = "Kunal";
////names[3] = "Ritesh"; // not possible array size is fixed

//Console.WriteLine(names[0]); // Ramesh

//for (int i = 0; i < names.Length; i++)
//{
//    Console.WriteLine(names[i]);
//}

#endregion array

#region array initializer syntax

//int[] numbers = new int[3];
//int[] numbers = new int[] { 10, 20, 30 ,50,40 };

//int[] abc = new int[2] { 10, 20};



//Console.WriteLine(" Number of length"+ numbers.Length);


//for(int i = 0; i< numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}






//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}

#endregion array initializer syntax

#region array example

//for (int i = 1; i <= 5; i++)
//{
//    Console.Write($"{i}\t");
//}

//for (int i = 1; i <= 5; i++)
//{
//    for (int j = 1; j <= 5; j++)
//    {
//        // Console.Write($"{i}i{j}j\t");
//        Console.Write($"{j}\t");
//    }
//    Console.WriteLine(); // new line
//}

//for (int i = 1; i <= 3; i++)
//{
//    for (int j = 1; j <= 3; j++)
//    {
//        Console.Write($"{i}i{j}j\t");

//        //if (i == j || (i == 3 && j <= 1) || (i <= 1 && j == 3))
//        //{
//        //    Console.Write($"*\t");
//        //}
//        //else
//        //{
//        //    Console.Write($" \t");
//        //}

//        if (i == j || (i == 3 && j <= 1) || (i <= 1 && j == 3))
//        {
//            Console.Write($"\t");
//        }
//        else
//        {
//            Console.Write($"*\t");
//        }
//    }
//    Console.WriteLine(); // new line
//}


//for (int i = 1; i <= 5; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write($"{j}\t");
//        // Console.Write($"*\t");
//    }
//    Console.WriteLine();
//}

//Console.WriteLine("***********************************************");

//for (int i = 5; i >= 1; i--)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write($"{j}\t");
//        // Console.Write($"*\t");
//    }
//    Console.WriteLine();
//}

#endregion array example

Console.ReadLine();