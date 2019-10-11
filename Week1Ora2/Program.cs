using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Ora2
{
    class Program
    {
        static void Main(string[] args)
        {
            //CitesteIntreg();

            //SumaPlusDiferenta();

            //DoWhileExamle();

            //ForExample();

           // WriteEvenNumbers();

            Console.ReadLine();
        }

        private static void WriteEvenNumbers()
        {
            for (int i = 0; i < 100; i += 2)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static void ForExample()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }
        }

        private static int DoWhileExamle()
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 1);


            while (i < 11)
            {
                Console.WriteLine(i);
                i++;
            }

            return i;
        }

        private static void SumaPlusDiferenta()
        {
            int nr1 = CitesteNumar();

            int nr2 = CitesteNumar();

            int suma = Suma(nr1, nr2);
            int dif = Diferenta(nr1, nr2);

            Console.WriteLine("Suma este " + suma);

            Console.WriteLine("Diferenta este:" + dif);
        }

        private static int CitesteNumar()
        {
            Console.WriteLine("Introduceti un numar:");
            string input = Console.ReadLine();
            int nr = int.Parse(input);

            return nr;
        }

        private static int Diferenta(int a, int b)
        {
            return a - b;
        }

        private static int Suma(int a, int b)
        {
            int suma = a + b;

            return suma;
        }

        private static void CitesteIntreg()
        {
            string input = Console.ReadLine();

            int inputTransformed = int.Parse(input);

            if (inputTransformed > 100)
            {
                Console.WriteLine("Numarul este mai mare ca 100");
            }
            else
            {
                Console.WriteLine("Numarul este mai mic ca 100");
            }
        }
    }
}
