using System;

namespace BaseLab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] M = new int[100];
            Random rand = new Random(DateTime.Now.Millisecond);
            Random n = new Random();
            int x;
            // Console.WriteLine("100 рандомных чисел:");
            for (x = 0; x < M.Length; x++)
            {
                int r = rand.Next(1001);
                M[x] = rand.Next(2) == 0 ? r : -r;
                // Console.Write(r + ", ");
            }
            Console.WriteLine("\nВывод четных чисел:");
            for (x = 0; x < M.Length; x++)
            {
                if (M[x] % 2 == 0)
                {
                    Console.Write(M[x] + ", ");
                }

            }
            Console.WriteLine("\nЧисла Кратные трем :");
            for (x = 0; x < M.Length; x++)

            {
                if (M[x] % 3 == 0)
                {
                    Console.Write(M[x] + ", ");
                }
            }
            Console.WriteLine("\nСумма всех отрицательных чисел :");
            int a = 0;
            for (x = 0; x < M.Length; x++)
            {
                if (M[x] < 0)
                {
                    a = a + M[x];
                }
            }
            Console.Write(a);

        }
    }
}
