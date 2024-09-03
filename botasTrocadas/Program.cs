using System;
class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        int[] Direita = new int[31]; //tamanhos das botas vão de 30 a 60, logo são 31 algarismos
        int[] Esquerda = new int[31];

        for (int i = 0; i < N; i++)
        {
            var linha = Console.ReadLine().Split(); //separa os dados "tamanho" e "lado" quando houver um espaço " ".
            //utiliza-se var pois este tipo se "adequa" aos outros tipos
            int tamanho = int.Parse(linha[0]) - 30; 
            char lado = linha[1][0];

            if (lado == 'D')
            {
                Direita[tamanho]++;
            }
            else if (lado == 'E')
            {
                Esquerda[tamanho]++;
            }
        }
        int pares = 0;
        for (int i = 0; i < 31; i++)
        {
            pares += Math.Min(Direita[i], Esquerda[i]); //retorna o menor de dois inteiros 
        }
        Console.WriteLine(pares);
    }
}
