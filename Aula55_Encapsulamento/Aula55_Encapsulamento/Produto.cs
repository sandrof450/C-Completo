﻿using System.Globalization;

namespace Aula42_Metodo
{
    public class Produto
    {

        private string _nome;
        private double _preco;
        private int _quantidade;


        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }


        public Produto(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = 5;
        }


        public string getNome()
        {
            return _nome;
        }

        public void setNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }


        public double getPreco()
        {
            return _preco;
        }

        public int getQuantidade()
        {
            return _quantidade;
        }


        public double ValorTotalEmEstoque()
        {

            return _preco * _quantidade;

        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }


        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }


        public override string ToString()
        {
            return _nome + ", $"
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " Uinidades, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}
