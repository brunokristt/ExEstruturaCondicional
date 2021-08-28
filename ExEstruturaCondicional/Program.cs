using System;
using System.Globalization;

namespace ExEstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de valores do catálogo");
            Console.Write("Digite o código do item: ");
            double codigo = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade do item: ");
            double quantidade = double.Parse(Console.ReadLine());
            double total = 0.00;
            string produto = "-";


                switch (codigo)
            {
                case 1:
                    total = 4.00 * quantidade;
                    produto = "Cachorro Quante";
                    break;

                case 2:
                    total = 4.50 * quantidade;
                    produto = "X-Salada";
                    break;
                case 3:
                    total = 5.00 * quantidade;
                    produto = "X-Bacon";
                    break;

                case 4:
                    total = 2.00 * quantidade;
                    produto = "Torrada Simples";
                    break;

                case 5:
                    total = 1.50 * quantidade;
                    produto = "Refrigerante";
                    break;
                default:
                    Console.WriteLine("Código não encontrado!");
                    break;
            }

            Console.WriteLine("Produto: " + produto);
            Console.WriteLine(" Quantidade: " + quantidade);
            Console.WriteLine(" Valor: " + total);


                
        }


    }
}               
                    

                
            
        
    

