using System;

namespace Notaaluno
{
    class Program
    {
        static void Main(string[]args)
        {
            //declare suas variaveis corretamente
            float calcular = 1;
            double[] notaAluno = new double[2];
            double res;
            //continue a solução ou implemente da sua maneira

            while (calcular == 1)
            {
                notaAluno[0] = double.Parse(Console.ReadLine());
                notaAluno[1] = double.Parse(Console.ReadLine());
                if (notaAluno[0] < 0 || notaAluno[0] > 10)
                {
                    Console.WriteLine("nota invalida");
                }
                else if (notaAluno[1] < 0 || notaAluno[1] > 10)
                {
                    Console.WriteLine("nota invalida");
                }
                else
                {
                    res = (notaAluno[0] + notaAluno[1]) / 2;

                    Console.WriteLine("media = " + res.ToString("N2"));
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    calcular = float.Parse(Console.ReadLine());
                        while (calcular != 1 && calcular != 2)
                        {
                            Console.WriteLine("novo calculo (1-sim 2-nao)");
                            calcular = float.Parse(Console.ReadLine());
                        }
                }
            }
        }
    }
}
