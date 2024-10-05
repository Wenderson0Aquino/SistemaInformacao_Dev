using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInformacao
{
    internal class Estoque
    {
        List<Produto> produtos = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            produtos.Add(produto);
        }

        public Produto BuscarProduto(int codigo)
        {
            return produtos.FirstOrDefault(p => p.Id == codigo);
        }

        public void ExcluirProduto(int codigo)
        {
            var prod = BuscarProduto(codigo);
            if (prod != null)
            {
                produtos.Remove(prod);
            }
        }
    }
}
