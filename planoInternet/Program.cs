using System;
class Program
{
    static void Main(string[] args)
    {
        int X = int.Parse(Console.ReadLine()); //QUOTA MENSAL
        int N = int.Parse(Console.ReadLine()); //MESES
        int quotaAtual = X;

        for(int i = 0; i < N; i++){
            int consumoMes = int.Parse(Console.ReadLine());

            quotaAtual -= consumoMes;
            quotaAtual += X;
        }
        Console.WriteLine(quotaAtual);
    }
}
