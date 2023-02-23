using System;

namespace Cases // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month = 3;
            switch (month)
            {
                case 1:
                    Console.WriteLine("number is 1");
                    break;
                case not 4:
                    Console.WriteLine("not 4");
                    break;
                default:
                    Console.WriteLine("probably 4");
                    break;
            }
        }
    }
}