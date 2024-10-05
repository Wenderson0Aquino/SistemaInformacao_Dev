using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInformacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto arroz = new Produto(1, "Arroz Sepé - Tipo 1", 6.45);
            arroz.ReajusteValor(5);
            Estoque estoque = new Estoque();
            estoque.AdicionarProduto(arroz);
            arroz.MostrarDados();
            Console.ReadKey();
        }
    }
}
