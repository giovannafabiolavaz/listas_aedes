//Giovanna Fabiola Vaz
using System;
class Program
{
    static void Main(string[] args)
    {
        //M numero de gols do time mandante
        //V numero de gols do time visitante
        //N casos de testes = 2 placares por caso 
        int N = int.Parse(Console.ReadLine());

        //casos de teste
        for (int i = 0; i < N; i++)
        {
            string[] partida1 = Console.ReadLine().Split('x');
            string[] partida2 = Console.ReadLine().Split('x');

            int time1M = int.Parse(partida1[0]);
            int time1V = int.Parse(partida2[1]);
            int time2V = int.Parse(partida1[1]);
            int time2M = int.Parse(partida2[0]);
            //total das duas partidas feito por cada time
            int totalTime1 = time1M + time1V;
            int totalTime2 = time2M + time2V;

            if (totalTime1 > totalTime2)
            {
                //time 1 fez mais ponto no somatório das partidas
                Console.WriteLine("Time 1");
            }
            else if (totalTime1 < totalTime2)
            {
                //time 2 fez mais ponto no somatório das partidas
                Console.WriteLine("Time 2");
            }

            //somatório é igual
            else if (totalTime1 == totalTime2)
            {
                //time 1 sendo visitante fez mais pontos que o time 2 sendo visitante
                if (time1V > time2V)
                {
                    Console.WriteLine("Time 1");
                }
                //time 2 sendo visitante fez mais pontos que o time 1 sendo visitante
                else if (time1V < time2V)
                {
                    Console.WriteLine("Time 2");
                }
                //ambos fizeram a mesma pontuação
                else if (time1V == time2V)
                {
                    Console.WriteLine("Penaltis");
                }
            }
        }
    }
}
