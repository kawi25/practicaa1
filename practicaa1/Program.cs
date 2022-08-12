using System;

namespace practicaa1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese su promdio");
            double nota = double.Parse(Console.ReadLine());
            if (nota >= 0 && nota <= 10)
                if (nota >= 6)

                    Console.WriteLine("aprobado");

                else if (nota >= 5)

                    Console.WriteLine("repiosicion");

                else
                    Console.WriteLine("reprovado");

            else

                Console.WriteLine("la nota no es corecta");


        }
    }
}
