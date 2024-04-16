using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization.Advanced;

namespace Despesas
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            double valor = 0;
            string resposta = "SIM";
            while (resposta == "SIM")
            {
                Console.WriteLine("Informe a despesa: ");
                string despesa = Console.ReadLine();
                Console.WriteLine("Qual é o valor da despesa? ");
                double precodespesa = double.Parse(Console.ReadLine());
                valor += precodespesa;
            }
            Console.WriteLine("Deseja inserir outra despesa? ");
            resposta = Console.ReadLine().ToLower();

            Console.WriteLine("O total de todas as despesas é "+valor .ToString("C"));

            Console.WriteLine("Quantas pessoas moram na casa? ");
             int moradores = int.Parse(Console.ReadLine());

            double media = valor / moradores;

            Console.WriteLine("A média de gastos por morador é " + media.ToString("C"));

            Console.ReadKey();

        }
    }
}
