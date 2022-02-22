using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
           string num1="", num2="";
            Console.WriteLine("Digite o primeiro número: ");
            num1=Console.ReadLine();
            Console.WriteLine("Digite o segundo número: ");
            num2=Console.ReadLine();

            double num3 = Convert.ToDouble(num1);
            double num4 = Convert.ToDouble(num2);

            Console.WriteLine("Adição: {0}", num3 + num4);
            Console.WriteLine("Subtração: {0}", num3 - num4);
            Console.WriteLine("Multiplicação: {0}", num3 * num4);
            Console.WriteLine("Divisão: {0}", num3 / num4);

            Console.ReadKey(true);

        }
    }
}
