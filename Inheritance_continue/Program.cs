using _18_InheritanceContinued;

class Progam
{
    static void Main()
    {
     //   //Customer c1 = new Customer();
     //   //c1.AllShows();
     //   //Console.WriteLine("Please provide your seat choice");
     //   //string type = Console.ReadLine();

     //   //int amount = c1.GetTicketAmount(type);
     //   //Console.WriteLine($"Ticket Amount is {amount}");
     //   //c1.PrintTicket();

     //   Customer sc = new SilverCustomer();
     //   // sc is a reference variable of type Customer class 
     //   // pointing to SilverCustomer type object
     //   sc.AllShows();
     //   int amt = ((SilverCustomer)sc).GetTicketAmount();
     //   Console.WriteLine(amt);
     //   // sc.PrintTicket();
     //   ((SilverCustomer)sc).PrintTicket();

     //   Console.WriteLine("********************************************");

     //   GoldCustomer gc = new GoldCustomer();
     //   gc.AllShows();
     ////int price =  gc.GetTicketAmount();
     ////   Console.WriteLine(price);
     //   gc.PrintTicket();

     //   Console.WriteLine("********************************************");

     //   PlatinumCustomer pc = new PlatinumCustomer();
     //   pc.AllShows();
        
     //   pc.PrintTicket();

     //   Console.WriteLine("********************************************");

     //   Customer c1 = new Customer(); // bc => bc
     //   c1.AllShows();

     //   Customer c2 = new SilverCustomer(); // bc => dc
     //   Customer c3 = new GoldCustomer();
     //   Customer c4 = new PlatinumCustomer();
     //   c2.PrintTicket();
     //   c3.PrintTicket();
     //   c4.PrintTicket();

     //   SilverCustomer sc1 = new SilverCustomer(); // dc => dc
     //   SilverCustomer sc2 = (SilverCustomer)new Customer(); // not possible

        //         int[] numbers = new int[3];
        //Customer[] customers = new Customer[3];
        //customers[0] = new SilverCustomer();
        //customers[1] = new GoldCustomer();
        //customers[2] = new PlatinumCustomer();

        //for (int i = 0; i < customers.Length; i++)
        //{
        //    int amount = customers[i].GetTicketAmount();
        //    Console.WriteLine(amount);
        //    customers[i].PrintTicket();
        //}



        // Base = Base
        Customer c1 = new Customer();
        c1.AllShows();
        c1.PrintTicket();

        Console.WriteLine("**********************************");
        
        //Derived = Derived
        GoldCustomer g1 = new GoldCustomer();
        g1.AllShows();
        g1.PrintTicket();

        Console.WriteLine("**********************************");

        //	Base = derived
        Customer c2 = new PlatinumCustomer();
        c2.AllShows();
        c2.PrintTicket();

        Console.WriteLine("**********************************");

        //	Derived = base // not possible

        // GoldCustomer g3 = new Customer();


        Console.ReadLine();
    }
}