//Giovanna Fabíola Vaz
using System;
class Program
{
    static void Main(string[] args)
    {
        //Número total de postes
        int N;

        //Condição de parada: N = 0
        while ((N = int.Parse(Console.ReadLine())) != 0)
        {
            int[] X = new int[N];
            //Leitura de todos os dados em uma só linha
            string[] str = Console.ReadLine().Split();

            //Preenche o vetor com 0 (sem poste) e 1 (com poste)
            for (int i = 0; i < N; i++)
            {
                X[i] = int.Parse(str[i]);
            }

            int postesMadeira = 0;

            for (int i = 0; i < N; i++)
            {
                if (X[i] == 0 && X[i + 1] == 0)
                {
                    postesMadeira++;
                    i++; //para pular o x+1 pois este já foi verificado
                }
            }

            //Verifica se o primeiro e o último estão como 0. Se estiverem, conta como mais um poste de madeira no local
            if (X[0] == 0 && X[N - 1] == 0)
            {
                if (X[1] != 0)
                {
                    postesMadeira++;
                }
            }

            Console.WriteLine(postesMadeira);
        }
    }
}
