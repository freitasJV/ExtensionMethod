using System;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2020, 4, 19, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
