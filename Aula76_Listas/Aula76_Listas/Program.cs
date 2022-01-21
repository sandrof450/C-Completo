using System;
using System.Collections.Generic;
namespace Aula76_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            list.Insert(2, "Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count: " + list.Count);

            //Mostra o valor dentro do index da primeira ocorrencia que começa com 'A'
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            //Mostra o valor dentro do index da ultima ocorrencia que começa com 'A'
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A'" + s2);

            //A posição da primeira ocorrencia que começa com letra 'A'
            int pos = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos);
            
            //A posição da ultima ocorrencia que começa com a letra 'A'
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            //Filtra apenas os nomes que tem 5 caracteres
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("---------------------------------------");
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }
            /*
            //Remove os caracteres passados como parametro
            list.Remove("Alex");
            Console.WriteLine("---------------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //Remove todos os elementos que contem 'M'
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("---------------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }*/
            
            list.RemoveAt(2);
            Console.WriteLine("---------------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Primeiro parametro mostra o inicio do index que deseja remover e o segundo parametro diz quantos elementos deseja remover
            //pra direita apatir do parametro que inciou
            list.RemoveRange(2, 2);
            Console.WriteLine("---------------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

        }

    }
}
