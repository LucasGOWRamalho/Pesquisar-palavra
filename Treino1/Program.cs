using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] palavras = { "maçã", "banana", "laranja", "cebola" };
        char letraProcurada;

        Console.WriteLine("Insira a letra que gostaria de procurar:");
        string input = Console.ReadLine();

        // Substitui o if por um loop para garantir que o usuário insira uma única letra
        while (input.Length != 1 || !char.TryParse(input, out letraProcurada))
        {
            Console.WriteLine("Por favor, insira uma única letra:");
            input = Console.ReadLine();
        }

        List<string> palavrasEncontradas = EncontrarPalavrasPorLetra(palavras, letraProcurada);

        if (palavrasEncontradas.Any())
        {
            Console.WriteLine($"Palavras encontradas com a letra '{letraProcurada}':");
            foreach (var palavra in palavrasEncontradas)
            {
                Console.WriteLine(palavra);
            }
        }
        else
        {
            Console.WriteLine($"Nenhuma palavra encontrada com a letra '{letraProcurada}'.");
        }
    }

    static List<string> EncontrarPalavrasPorLetra(string[] palavras, char letra)
    {
        // Utiliza LINQ para filtrar as palavras que contêm a letra especificada
        return palavras.Where(palavra => palavra.Contains(letra)).ToList();
    }
}
