using System;

class Variaveis
{
    static void Main(String[] args)
    {
        Console.WriteLine("Criando variáveis:");

        int idade = 27;

        Console.WriteLine($"Idade é {idade}");
        Console.ReadLine();

        //Double
        double preco = 22.4;

        Console.WriteLine($"O preço é{preco}");

        //char is used to store a charactere value between simple quotes
        char letra = 'A';

        //string type is used to store a phare value between double quotes
        string frase = "Just a test frase";

        string lista = @"Lingugens:
        -GO
        -C#
        -Python
        -Java";

        Console.WriteLine($"São: {lista}");
    }
}
