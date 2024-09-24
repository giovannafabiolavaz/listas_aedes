//Giovanna Fabíola Vaz
using System;
namespace papaiNoel;
class Program
{
    static void Main(string[] args)
    {
        //Quantidade de crianças
        int N = int.Parse(Console.ReadLine());

        string[] nomes = new string[N];

        //Variáveis contadoras de crianças comportadas e não comportadas
        int compBem = 0, compMal = 0;

        //Monta a lista com nomes e comportamento da criança
        for (int i = 0; i < N; i++)
        {
            string[] str = Console.ReadLine().Split(); //lê e divide a entrada
            char comportamento = char.Parse(str[0]); //comportamento é a parte antes do espaço
            nomes[i] = str[1]; //nome é a parte após o espaço

            //Verifica quantas crianças se comportaram e não se comportaram
            if (comportamento == '-')
            {
                compMal++;
            }
            else if (comportamento == '+')
            {
                compBem++;
            }
        }

        //Ordena os nomes utilizando o Bubble Sort
        for (int i = 0; i < N - 1; i++)
        {
            for (int j = 0; j < N - 1; j++)
            {
                //String.Compare compara duas Strings e ordena em ordem alfabética
                if (String.Compare(nomes[j], nomes[j + 1]) > 0)
                {
                    string temp = nomes[j];
                    nomes[j] = nomes[j + 1];
                    nomes[j + 1] = temp;
                }
            }
        }

        //Imprime os nomes ordenados alfabeticamente 
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }

        //Imprime o valor de crianças comportadas e não comportadas
        Console.WriteLine($"Se comportaram: {compBem} | Nao se comportaram: {compMal}");
    }
}