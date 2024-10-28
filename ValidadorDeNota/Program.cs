//obs: Deve ser utilizado estrutura repetitiva While:
//Problema "validacao_de_nota" (adaptado de URI 1117)
//Faça um programa que leia as notas referentes às duas avaliações de um aluno. Calcule e imprima a
//média semestral. Faça com que o algoritmo só aceite notas válidas (uma nota válida deve pertencer ao
//intervalo [0,10]). Cada nota deve ser validada separadamente. 

using System.Globalization;
using System.Net.Http.Headers;

namespace ValidadorDeNota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine(), CI);

            while (nota1 < 0 || nota1 > 10)
            {
                Console.Write("Valor invalido! Tente novamente:");
                nota1 = double.Parse(Console.ReadLine(), CI);
            }

            Console.Write("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine(), CI);

            while (nota2 < 0 || nota2 > 10)
            {
                Console.Write("Valor invalido! Tente novamente:");
                nota2 = double.Parse(Console.ReadLine(), CI);
            }

            media = (nota1 + nota2) / 2;

            Console.WriteLine($"MEDIA = {media.ToString("F2", CI)}");
        }
    }
}
