using System;

class Condicionais
{
    static void Main(string[] args)
    {
        Console.WriteLine("Condicionais");

        int idade = 16;

        if (idade >= 18)
        {
            Console.WriteLine("Aceito");
        }else
        {
            Console.WriteLine("Não aceito");
        }

        /*
         Operador Ternário
        
         tipo nomeVariavel = condição ? True : False;

         */
        string resultado = idade >= 18 ? "Sim" : "Não";
    }
}