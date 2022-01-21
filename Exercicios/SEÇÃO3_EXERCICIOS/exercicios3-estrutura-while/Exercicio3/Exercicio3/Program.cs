﻿/*Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
exemplo.*/
using System;

namespace Exercicio3 { 
    class Exercicio3{

        static void Main(string[] args){

            int alcool, gasolina, diesel;
            alcool = gasolina = diesel = 0;

            Console.Write("Digite o tipo de combustivel que deseja: ");
            int combustivel = int.Parse(Console.ReadLine());

            while (combustivel != 4){

                if (combustivel == 1) {
                    alcool += 1;                    
                }

                else if (combustivel == 2)
                {
                    gasolina += 1;
                }
                else if (combustivel == 3)
                {
                    diesel += 1;
                }

                Console.Write("Digite o tipo de combustivel que deseja: ");
                combustivel = int.Parse(Console.ReadLine());

            }

            Console.WriteLine($"MUITO OBRIGADO" +
                $"\nAlcool: {alcool}\n" +
                $"Gasolina: {gasolina}\n" +
                $"Diesel: {diesel}");

        }
    }
}

