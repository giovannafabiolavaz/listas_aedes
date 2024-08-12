namespace Revisao
{
    internal class Questao1
    {
        public static void Rodar()
        {
            Console.WriteLine("Digite dois numeros para verificar se eles sao numeros amigos:\n");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int totalX = 0, totalY = 0;

            for(int i = 1; i < x; i++){
                if(x % i == 0){
                    totalX += i;
                }
            }  
            for(int i = 1; i < y; i++){
                if(y % i == 0){
                    totalY += i;
                }
            }
            if(totalX == y && totalY == x){
                Console.WriteLine($"{x} e {y} sao numeros amigos!");
            }
            else 
            Console.WriteLine($"{x} e {y} nao sao numeros amigos!");
        }
    }
}