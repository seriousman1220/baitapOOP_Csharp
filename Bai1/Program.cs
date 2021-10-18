using System;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DateTime dob = new DateTime(1980, 5, 20);
            Programmer p1 = new Programmer(1,"Nguyen Van A", "Good Communications, Expert in JAVa", dob);

            p1.ShowInfo();
            Console.ReadKey();
        }
    }
}
