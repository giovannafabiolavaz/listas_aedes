//Giovanna Fabíola Vaz
using System;
namespace quadroMedalhas;
class Program
{
    static void Main(string[] args)
    {
        //Número de países
        int n = int.Parse(Console.ReadLine());
        //Vetores de países, ouros, pratas e bronzes
        string[] paises = new string[n];
        int[] ouros = new int[n];
        int[] pratas = new int[n];
        int[] bronzes = new int[n];

        //Preenche vetores de acordo com a entrada (nome, ouro, prata, bronze)
        for (int i = 0; i < n; i++)
        {
            string[] str = Console.ReadLine().Split();
            paises[i] = str[0];
            ouros[i] = int.Parse(str[1]);
            pratas[i] = int.Parse(str[2]);
            bronzes[i] = int.Parse(str[3]);
        }

        //ordenando utilizando o Bubble Sort
        for(int i = 0; i < n - 1; i++)
        {
            for(int j = 0; j < n - 1 - i; j++)
            {
                //Condição de ordenação
                if((ouros[j] < ouros[j + 1]) || (ouros[j] == ouros[j + 1] && pratas[j] < pratas[j + 1]) || (ouros[j] == ouros[j + 1] && pratas[j] == pratas[j + 1] && bronzes[j] < bronzes[j + 1]) || (ouros[j] == ouros[j + 1] && pratas[j] == pratas[j + 1] && bronzes[j] == bronzes[j + 1] && String.Compare(paises[j], paises[j + 1]) > 0))
                {
                    //Ordena os países
                    string temp = paises[j];
                    paises[j] = paises[j + 1];
                    paises[j + 1] = temp;

                    //Ordena os ouros
                    int tempOuro = ouros[j];
                    ouros[j] = ouros[j + 1];
                    ouros[j + 1] = tempOuro;

                    //Ordena as pratas
                    int tempPrata = pratas[j];
                    pratas[j] = pratas[j + 1];  
                    pratas[j + 1] = tempPrata;

                    //Ordena os bronzes
                    int tempBronzes = bronzes[j];
                    bronzes[j] = bronzes[j + 1];
                    bronzes[j + 1] = tempBronzes;
                }
            }
        }

        //Imprime uma linha vazia 
        Console.WriteLine();

        //Imprime o quadro de medalhas ordenado
        for(int i = 0; i < n; i++){
            Console.WriteLine($"{paises[i]} {ouros[i]} {pratas[i]} {bronzes[i]}");
        }
    }
}
