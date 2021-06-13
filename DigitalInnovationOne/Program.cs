// CRIANDO UMA APLICAÇÃO CONSOLE.

using System;

namespace DigitalInnovationOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hello World
            // Console.WriteLine("Hello World!");

            //-------------------------------------------------

            // Laço de repetição.
            int numeroDeVezes = 5;

            for (int i=0; i < numeroDeVezes; i++) {
                Console.WriteLine($"Bem-vindo ao curso de .Net {i}");
            }
        }
    }
}
