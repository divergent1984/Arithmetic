using System;

namespace Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {//создаём три рандомных числа.
            Random rnd = new Random();
            int A = rnd.Next(1, 10);
            int B = rnd.Next(1, 10);
            int C = rnd.Next(1, 100);
            //умножаем число А на B.
            int sum = A * B;
            //если сумма ранна числу С выводим YES.
            if (sum==C)
            {
                Console.WriteLine(A +"*"+B +"="+ C+" "+"YES");
            }
            // если нет выводим NO
            else
            {
                Console.WriteLine(A + "*" + B + " !=" + C + " "+"NO");
            }

            Console.ReadKey();
        }
    }
}
