﻿using System.Globalization;

namespace Aula42_Metodo
{
    public class Produto
    {

        private string _nome;
        public double Preco { get; private set;}
        public int Quantidade { get; private set;}


        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }


        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = 5;
        }


        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
   
        public double ValorTotalEmEstoque()
        {

            return Preco * Quantidade;

        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }


        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }


        public override string ToString()
        {
            return _nome + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " Uinidades, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}
