namespace lista_teorica
{
    internal class questao5
    {
        public static void Rodar()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int number = i;
                bool composto = true;
                while (number > 0)
                {
                    int digit = number % 10;
                    if (digit != 1 && digit != 3 && digit != 5)
                    {
                        composto = false;
                        break;
                    }
                    number /= 10;
                }
                if (composto)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}