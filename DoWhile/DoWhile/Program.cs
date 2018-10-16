using System;


namespace DoWhile
{
    class Program
    {
        static void Main()
        {
          
            do
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
            }
            while (false);


            Console.Read();
        }
    }
}
