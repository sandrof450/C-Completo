using System;
namespace Aula88_Funcoes_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG    ";
            
            //Joga tudo pra maiusculo
            string s1 = original.ToUpper();

            //Joga tudo pra minusculo
            string s2 = original.ToLower();

            //Apaga todos os espaços em branco tanto no inicio da frase quanto no final
            string s3 = original.Trim();

            //Pega a primeira posição da string inserida como parametro
            int n1 = original.IndexOf("bc");

            //Pega a ultima posição da string inserida como parametro
            int n2 = original.LastIndexOf("bc");

            //tira tudo que esiver antes do index inserido como parametro nesse caso é o 3
            string s4 = original.Substring(3);

            ////tira tudo que esiver antes do index inserido como parametro nesse caso é o 3 e 
            ///insere a quantidade de string colocada no segundo parametro nesse caso é 5
            string s5 = original.Substring(3, 5);

            //Troca todo caractere 'a' pelo caractere 'x'
            string s6 = original.Replace('a', 'x');

            //Troca toda string "abc" pelo caractere "xy"
            string s7 = original.Replace("abc", "xy");

            //Verifica se a string está com valor vazio ou Nulo, caso esteja vazio dá True caso contrario da False
            bool b1 = String.IsNullOrEmpty(original);

            //Verifica se a string está com valor vazio, Nulo ou varios espaços em branco, caso esteja vazio dá True caso contrario da False
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine($"Original: {original} -");
            Console.WriteLine($"Toupper: {s1} -");
            Console.WriteLine($"ToLower: {s2} -");
            Console.WriteLine($"Trim: {s3} -");
            Console.WriteLine($"IndexOf: {n1}");
            Console.WriteLine($"LastIndexOf: {n2}");
            Console.WriteLine($"SubString(3): {s4} -");
            Console.WriteLine($"SubString(3, 5): {s5} -");
            Console.WriteLine($"Replace('a', 'x'): {s6} -");
            Console.WriteLine($"Replace('abc', 'xy'): {s7} -");
            Console.WriteLine($"IsNullOrEmpty: {b1} -");
            Console.WriteLine($"IsNullOrWhiteSpace: {b2} -");

        }
    }
}