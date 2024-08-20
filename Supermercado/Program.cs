using System;
class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        double menor = double.MaxValue;

        for(int i = 0; i < N; i++){
            string [] dados = Console.ReadLine().Split();
            double P = double.Parse(dados[0]);
            int G = int.Parse(dados[1]);

            double precoTotal = (P * 1000) / G; // Calcula o valor por quilo

            if(precoTotal < menor){
                menor = precoTotal;
            }
        }

        Console.WriteLine($"{menor:F2}");
    }
}
