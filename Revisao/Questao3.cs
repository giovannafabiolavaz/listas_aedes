namespace Revisao
{
    internal class Questao3
    {
        public static void Rodar()
        {
            Console.WriteLine("Insira 3 numeros para verificar se eles formam um triangulo: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            if ((x + y > z) && (x + z > y) && (y + z > x))
            {
                if (x == y && y == z)
                {
                    Console.WriteLine("Triangulo Equilatero!");
                }
                if ((x == y && y != z) || (x == z && z != y) || (y == z && z != x))
                {
                    Console.WriteLine("Triangulo Isoceles!");
                }
                if (x != y && y != z)
                {
                    Console.WriteLine("Triangulo Escaleno!");
                }
            }
            else
            {
                Console.WriteLine("Os tres valores nao formam um triangulo.");
            }
        }
    }
}