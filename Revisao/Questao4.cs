namespace Revisao
{
    internal class Questao4
    {
        public static void Rodar()
        {
            Console.WriteLine("Insira um intervalo para verificar a quantidade de numeros primos nele contidos: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            // verificando se x < y
            int aux = 0;
            if (x > y)
            {
                aux = x;
                x = y;
                y = aux;
            }

            int primo = 0;

            for (int i = x; i <= y; i++)
            {
                int cont = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        cont++;
                    }
                }
                if(cont == 2){
                    primo++;
                }
            }
            if(primo > 0){
                Console.WriteLine($"Existe(m) {primo} numero(s) primo(s) no intervalo de {x} a {y}.");
            }
            else{
                Console.WriteLine("O intervalo nao contem numeros primos.");
            }
        }
    }
}