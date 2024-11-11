//Giovanna Fabíola Vaz
using System;

class Program
{
    static void Main(string[] args)
    {
        //Faz a primeira leitura para entrar no loop while
        string[] str = Console.ReadLine().Split();
        int N = int.Parse(str[0]);
        int M = int.Parse(str[1]);
        
        while (N != 0 && M != 0)
        {
            int[,] competicao = new int[N, M];
            
            for(int i = 0; i < N; i++)
            {
                //entra com todos os dados de um candidato e separa os dados nas colunas (respectivos problemas)
                string[] linha = Console.ReadLine().Split();
                for(int j = 0;  j < M; j++)
                {
                    competicao[i, j] = int.Parse(linha[j]);
                }
            }

            bool c1 = true; // Ninguém resolveu todos os problemas
            bool c2 = true; // Todo problema foi resolvido por pelo menos uma pessoa
            bool c3 = true; // Não há nenhum problema resolvido por todos
            bool c4 = true; // Todos resolveram ao menos um problema


            //Verifica se alguém resolveu todos os problemas
            for(int i = 0; i < N; i ++) 
            {
                bool resolveuTudo = true;
                for(int j = 0; j < M; j++) 
                {
                    //caso alguma coluna j esteja com 0, significa que o problema não foi resolvido
                    if(competicao[i, j] == 0)
                    {
                        resolveuTudo = false;
                        break;
                    }
                }
                if(resolveuTudo)
                {
                    c1 = false;
                    break;
                }
            }

            //Verifica se todos os problemas foram resolvidos por pelo menos uma pessoa
            for(int i = 0; i < N; i ++) 
            {
                bool alguemResolveu = false;
                for(int j = 0; j < M; j++) 
                {
                    if(competicao[i, j] == 1)
                    {
                        alguemResolveu = true;
                        break;
                    }
                }
                if(!alguemResolveu)
                {
                    c2 = false;
                    break;
                }
            }

            //Verifica se existe algum problema resolvido por todos
            for(int i = 0; i < N; i ++) 
            {
                bool probResolvido = true;
                for(int j = 0; j < M; j++) 
                {
                    if(competicao[i, j] == 0)
                    {
                        probResolvido = false;
                        break;
                    }   
                }
                if(probResolvido)
                {
                    c3 = false;
                    break;
                }
            }

            //Verifica se todos resolveram ao menos um problema
            for(int i = 0; i < N; i ++) 
            {
                bool peloMenosUm = false;
                for(int j = 0; j < M; j++) 
                {
                    if(competicao[i, j] == 1)
                    {
                        peloMenosUm = true;
                        break;
                    }   
                }
                if(!peloMenosUm)
                {
                    c4 = false;
                    break;
                }
            }

            int count = 0;
            if(c1 == true){
                count++;
            }
            if(c2 == true){
                count++;
            }
            if(c3 == true){
                count++;
            }
            if(c4 == true){
                count++;
            }

            Console.WriteLine(count);

            //Lê o(s) próximo(s) caso(s) de teste
            str = Console.ReadLine().Split();
            N = int.Parse(str[0]);
            M = int.Parse(str[1]);
        }
    }
}