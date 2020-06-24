using System;

namespace Aula22RealDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine("Conversão de Valores em Dolar:");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;

            Conversor.CotacaoDolar = 5.29f;
            Console.WriteLine( Conversor.DolarParaReal(55) );
            Console.WriteLine( Conversor.RealParaDolar(55) );

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine("Conversão de Valores em Euro:");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;

            Conversor.CotacaoEuro = 5.98f;
            Console.WriteLine( Conversor.EuroParaReal(55) );
            Console.WriteLine( Conversor.RealParaEuro(55) );

            Console.ResetColor();
        }
    }
}