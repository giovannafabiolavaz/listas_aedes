//Giovanna Fabíola Vaz
using System;
namespace Pokemon;
// Cria o "nó", com os valores armazenados -> Código fornecido pelo professor felipe
class CCelula
{
    public Object Item; // O Item armazenado pela célula
    public CCelula Prox; // Referencia a próxima célula
    public CCelula()
    {
        Item = null;
        Prox = null;
    }

    public CCelula(object ValorItem)
    {
        Item = ValorItem;
        Prox = null;
    }

    public CCelula(object ValorItem, CCelula ProxCelula)
    {
        Item = ValorItem;
        Prox = ProxCelula;
    }
}
public class Pokemon
{
    public int id;
    public int generation;
    public string Nome;
    public string description;
    public string typel;
    public string type2;
    public float weight_kg;
    public float height_m;
    public int capture_rate;
    public bool Is_legendary;
    public DateTime capture_date;
    public string abilities;

    public Pokemon(int id, int generation, string Nome, string description, string typel, string type2,
                    float weight_kg, float height_m, int capture_rate, bool Is_legendary, DateTime capture_date,
                    string abilities)
    {
        this.id = id;
        this.generation = generation;
        this.Nome = Nome;
        this.description = description;
        this.typel = typel;
        this.type2 = type2;
        this.weight_kg = weight_kg;
        this.height_m = height_m;
        this.capture_rate = capture_rate;
        this.Is_legendary = Is_legendary;
        this.capture_date = capture_date;
        this.abilities = abilities;
    }

    public override string ToString()
    {
        return $"ID: {id}, Generation: {generation}, Nome: {Nome}, Description: {description}, Type1: {typel}, Type2: {type2}, Weight: {weight_kg}kg, Height: {height_m}m, CaptureRate: {capture_rate}, Legendary: {Is_legendary}, CaptureDate: {capture_date.ToString("yyyy-MM-dd")}, Abilities: {abilities}";
    }
}

// Cria a Fila, utilizada nas batalhas, para retornar e para liberar pokemons -> Código fornecido pelo professor felipe
class CFila
{
    private CCelula Frente; // Referencia a primeira célula da fila (cabeça)
    private CCelula Tras;   // Referencia a última célula da fila
    private int Qtde = 0;   // Quantidade de elementos na fila

    public CFila()
    {
        Frente = new CCelula();
        Tras = Frente;
    }

    public bool EstaVazia()
    {
        return Frente == Tras;
    }

    public void Enfileira(Object ValorItem)
    {
        Tras.Prox = new CCelula(ValorItem);
        Tras = Tras.Prox;
        Qtde++;
    }

    public Object Desenfileira()
    {
        Object Item = null;
        if (Frente != Tras)
        {
            Frente = Frente.Prox;
            Item = Frente.Item;
            Qtde--;
        }
        return Item;
    }

    public Object Peek()
    {
        return (Frente != Tras) ? Frente.Prox.Item : null;
    }

    public int Quantidade()
    {
        return Qtde;
    }
}

// Cria a pilha, utilizada para capturar e preparar pokemons -> Código fornecido pelo professor felipe
class CPilha
{
    private CCelula Topo = null; // Referencia o topo da pilha
    private int Qtde = 0;        // Quantidade de elementos na pilha

    public CPilha()
    {
    }

    // Se estiver vazia, o topo é definido como nulo
    public bool EstaVazia()
    {
        return Topo == null;
    }

    public void Empilha(Object ValorItem)
    {
        Topo = new CCelula(ValorItem, Topo);
        Qtde++;
    }

    public Object Desempilha()
    {
        Object Item = null;
        if (Topo != null)
        {
            Item = Topo.Item;
            Topo = Topo.Prox;
            Qtde--;
        }
        return Item;
    }

    public Object Peek()
    {
        return (Topo != null) ? Topo.Item : null;
    }

    public int Quantidade()
    {
        return Qtde;
    }
}

// Possui funções que capturam, preparam, liberam, retornam e criam batalhas entre pokemons
public class gerenciadorPokemon
{
    private CFila filaEspera = new CFila();
    private CPilha pilhaBatalha = new CPilha();

    public void Captura(Pokemon pokemon)
    {
        pilhaBatalha.Empilha(pokemon);
        Console.WriteLine(pokemon.Nome);
    }

    public void Prepara()
    {
        var pokemon = pilhaBatalha.Desempilha();
        if (pokemon != null)
        {
            filaEspera.Enfileira(pokemon);
            Console.WriteLine(filaEspera);
        }
    }

    public void Batalha()
    {
        var pokemon = filaEspera.Desenfileira();
        if (pokemon != null)
        {
            Console.WriteLine(pokemon);
        }
    }

    public void Retorna()
    {
        var pokemon = filaEspera.Desenfileira();
        if (pokemon != null)
        {
            pilhaBatalha.Empilha(pokemon);
            Console.WriteLine(((Pokemon)pokemon).Nome);
        }
    }
    public void Libera()
    {
        var pokemon = filaEspera.Desenfileira();
        if (pokemon != null)
        {
            Console.WriteLine(pokemon);
        }
    }
}

class Program
{
    static void Main()
    {
        gerenciadorPokemon gerenciador = new gerenciadorPokemon();
        // Quantidade de pokemons
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            //Leitura dos dados dos pokemons
            var dados = Console.ReadLine().Split(' ');
            int id = int.Parse(dados[0]);
            int generation = int.Parse(dados[1]);
            string Nome = dados[2];
            string description = dados[3];
            string typel = dados[4];
            string type2 = dados[5];
            float weight_kg = float.Parse(dados[6]);
            float height_m = float.Parse(dados[7]);
            int capture_rate = int.Parse(dados[8]);
            bool Is_legendary = bool.Parse(dados[9]);
            var capture_date = new DateTime(0, 1, 1);
            string abilities = dados[10];

            Pokemon pokemon = new Pokemon(id, generation, Nome, description, typel, type2, weight_kg, height_m, capture_rate, Is_legendary, capture_date, abilities);
            gerenciador.Captura(pokemon);
        }
        // Quantidade de comandos
        int Q = int.Parse(Console.ReadLine());

        for (int i = 0; i < Q; i++)
        {
            string comando = Console.ReadLine();

            // Usuário seleciona o comando que deseja executar
            switch (comando)
            {
                case "C":
                    var dados = Console.ReadLine().Split(' ');
                    int id = int.Parse(dados[0]);
                    int generation = int.Parse(dados[1]);
                    string Nome = dados[2];
                    string description = dados[3];
                    string typel = dados[4];
                    string type2 = dados[5];
                    float weight_kg = float.Parse(dados[6]);
                    float height_m = float.Parse(dados[7]);
                    int capture_rate = int.Parse(dados[8]);
                    bool Is_legendary = bool.Parse(dados[9]);
                    var capture_date = new DateTime(0, 1, 1);
                    string abilities = dados[10];
                    Pokemon pokemon = new Pokemon(id, generation, Nome, description, typel, type2, weight_kg, height_m, capture_rate, Is_legendary, capture_date, abilities);
                    gerenciador.Captura(pokemon);
                    break;
                case "P":
                    gerenciador.Prepara();
                    break;
                case "B":
                    gerenciador.Batalha();
                    break;
                case "R":
                    gerenciador.Retorna();
                    break;
                case "L":
                    gerenciador.Libera();
                    break;
                default:
                    break;
            }
        }
    }
}

