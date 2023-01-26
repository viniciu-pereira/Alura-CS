using System;
using System.Diagnostics.Metrics;

class Repeticao
{
    static void Main(String[] args)
    {
        double investimento = 1000;
        double taxa = 0.005;
        /*
         * Coleta de dados do prompt:
        int meses = int.Parse(Console.ReadLine());
        */

        //rendimento de 0,5% a.m. (0.005)
        // investimento = investimento + (investimento * taxa);

        int meses = 1;
        while (meses <= 12)
        {
            investimento = investimento + (investimento * taxa);
            Console.WriteLine($"Valor investido no mês {meses} é ${investimento}");
            meses++;
        }

        //Keep prompt open
        Console.ReadLine();
        

    }
}
