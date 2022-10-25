//Fibonacci series in c#. The user will tell us the number he wants for the series

using System;

namespace fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int totalNumber, K;
            int A, B, C;

            Console.Write("Tell me the numbers you want in the Fibonacci series: ");
            totalNumber = int.Parse(Console.ReadLine());

            A = 1; B = 1;
            Console.Write(A + " " + B + " ");
            for (K = 3; K <= totalNumber; K++)
            {
                C = A + B;
                Console.Write(C + " ");

                //we change the values
                A = B;
                B = C;
            }
            Console.WriteLine();
        }
    }
}