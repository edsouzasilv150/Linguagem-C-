// ESTRUTURA DE DADOS - PILHA
using System;
using EstruturasDeDados.pilha_pratos;

namespace EstruturasDeDados 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            var pratos = new Pilha();
            pratos.Empilha("Prato 01");
            pratos.Empilha("Prato 02");
            pratos.Empilha("Prato 03");
            pratos.Empilha("Prato 04");
            pratos.Empilha("Prato 05");
            Console.WriteLine(pratos.Desempilha());
            Console.WriteLine(pratos.Desempilha());
            Console.WriteLine(pratos.Desempilha());
            Console.WriteLine(pratos.Desempilha());
            Console.WriteLine(pratos.Desempilha());
            Console.WriteLine(pratos.Desempilha());
        }
    }
}
