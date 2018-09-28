using System;

namespace senai.operadores.ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 7");

            Console.WriteLine("Informe o nome do produto");
            string nome = Console.ReadLine();

            Console.WriteLine("informe o preço( >0 )");
            decimal preço = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Total da compra R${preço}");

            decimal desconto = (decimal)(preço - (preço / 100 * 10));

            Console.WriteLine($"Parabéns você ganhou um desconto de 10% e o preço de {nome} ficou R${desconto}");
        }
    }
}
