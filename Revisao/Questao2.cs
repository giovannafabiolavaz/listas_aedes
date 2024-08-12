namespace Revisao
{
    internal class Questao2
    {
        public static void Rodar()
        {
            Console.WriteLine("Insira um numero para verificar se eh um numero perfeito: ");
            int num = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    soma += i;
                }
            }

            if (soma == num)
            {
                Console.WriteLine($"{num} eh um numero perfeito!");
            }
            else
            {
                Console.WriteLine($"Nao eh um numero perfeito, pois a soma dos divisores resultou em {soma}.");
            }
        }
    }
}