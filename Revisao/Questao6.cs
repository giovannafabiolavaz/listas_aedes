namespace Revisao 
{
    internal class Questao6
    {
        public static void Rodar()
        {
            int [] conjunto1 = new int [10];
            int [] conjunto2 = new int [10];
            int [] resultado = new int [10];

            Console.WriteLine("Insira o primeiro conjunto de 10 numeros: ");
            for(int i = 0; i < 10; i++){
                conjunto1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Agora, insira o segundo conjunto de 10 numeros: ");
            for(int i = 0; i < 10; i++){
                conjunto2[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < 10; i++){
                if(conjunto1[i] <= conjunto2[i]){
                    resultado[i] = conjunto1[i];
                }
                else if(conjunto1[i] >= conjunto2[i]){
                    resultado[i] = conjunto2[i];
                }
            }

            Console.Write("Resultado: ");
            for(int i = 0; i < 10; i++){
                Console.Write(resultado[i] + " ");
            }
        }
    }
}