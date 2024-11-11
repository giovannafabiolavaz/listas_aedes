//Giovanna Fabiola Vaz
namespace descobrindoSenha;
class Program
{
    static void Main(string[] args)
    {
        int N;
        int count = 1;
        while ((N = int.Parse(Console.ReadLine())) != 0)
        {
            //vetor com os 10 valores
            float[] V = new float[10];
            int[] senha = new int[10];
            //Vetor que armazena os dígitos da senha
            string[] str = Console.ReadLine().Split();

            for (int i = 0; i < 10; i++)
            {
                V[i] = float.Parse(str[i]);
                senha[i] = i;
            }


            //Ordenando (método bubble sort) os valores do vetor de forma decrescente para depois imprimir os N primeiros numeros
            for (int i = 0; i < 10 - 1; i++)
            {
                for (int j = 0; j < 10 - i - 1; j++)
                {
                    if (V[j] < V[j + 1])
                    {
                        //Ordena o vetor em forma decrescente
                        float temp = V[j];
                        V[j] = V[j + 1];
                        V[j + 1] = temp;

                        // Troca os valores de dígitos correspondentes
                        int aux = senha[j];
                        senha[j] = senha[j + 1];
                        senha[j + 1] = aux;
                    }
                }
            }

            Console.Write($"Caso {count}: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(senha[i]);
            }
            count++;
            Console.WriteLine();
        }
    }
}