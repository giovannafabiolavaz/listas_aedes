namespace Revisao
{
    internal class Questao5
    {
        public static void Rodar()
        {
            Console.WriteLine("Insira dois valores para verificar o MMC e o MDC deles: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int MDC = calculaMDC(x, y);
            int MMC = calculaMMC(x, y, MDC);
            Console.WriteLine("MMC = " + MMC);
            Console.WriteLine("MDC = " + MDC);
        }
        static int calculaMMC(int x, int y, int MDC)
        {
            return Math.Abs(x * y) / MDC;;
        }
        
        static int calculaMDC(int x, int y)
        {
            while(y != 0){
                int aux = y;
                y = x % y;
                x = aux;
            }
            return x;
        }
    }
}