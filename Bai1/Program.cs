using System;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            DateTime dob2 = new DateTime(2001, 1, 1);
            Programmer p3 = new Programmer(2, "Nguyen Tuan Anh", "Good job, amazing,", dob2);
            p3.ShowInfo();
            Console.ReadKey();
        }
    }
}
