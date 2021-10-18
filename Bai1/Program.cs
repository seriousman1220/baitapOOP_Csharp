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
            DateTime dob2 = new DateTime(2001, 1, 1);
            Programmer p2 = new Programmer(2, "Nguyen Tuan Anh", "Amazing good job", dob2);
            p1.ShowInfo();
            p2.ShowInfo();
            Console.ReadKey();
        }
    }
}
