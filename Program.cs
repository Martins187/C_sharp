using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadiet, cik Fibonacci virknes skaitļus vēlaties lai izvada!");
            int a = Convert.ToInt32(Console.ReadLine());
            int y = 0;
            int c = 0;
            int z = 1;

            for(int i = 0; i < a; i++)
            {
                Console.Write(y + " ");
                c = y;
                y = y + z;
                z = c;
            }
        }
    }
}
