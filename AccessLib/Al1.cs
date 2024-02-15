namespace AccessLib
{
    public class Al1
    {
        public Al1()
        {
            PrintA();
        }

        public void Print()
        {
            Console.WriteLine("AL1 Print() Called");

            AL2 a2 = new AL2();
            a2.Print();

            PrintA();
            PrintB();
        }

        private void PrintA() // accessible only within same class
        {
            Console.WriteLine("AL1 PrintA() Called");
        }

        protected void PrintB()
        {
            Console.WriteLine("AL1 PrintB() Called");
        }

        protected internal void PrintC()
        {
            Console.WriteLine("AL1 PrintC() Method Called");
        }
    }

    internal class AL2 : Al1
    {
        public void Print()
        {
            Console.WriteLine("AL2 Print() Called");
            base.Print();
           // base.PrintA(); // PrintA() is private
            base.PrintB();
            base.PrintC(); // protected internal
        }
    }

    public class AL3 
    {
        public void Print()
        {
            Al1 a1 = new Al1();
            a1.Print();
            // a1.PrintA(); // it is private
            //a1.PrintB(); // it is protected
           // base.PrintB();
            a1.PrintC(); // it is because internal
        }
    }

    public class AL
    {
        private void Print()
        {
            Console.WriteLine("AL Print() : private");
        }

        public void PrintA()
        {
            Console.WriteLine("AL PrintA() : public");
            Print(); // private method
        }
    }
}