using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInformacao
{
    internal class Produto
    {
        int id;
        string descricao;
        double valor;

        public int Id { get => id; set => id = value; }

        public Produto(int id, string descricao, double valor)
        {
            this.descricao = descricao;
            this.valor = valor;
            this.id = id;
        }

        public void ReajusteValor(double percentual)
        {
            this.valor += this.valor * percentual / 100;
            Console.WriteLine(this.valor);
        }

        public void MostrarDados()
        {
            Console.WriteLine("Descrição " + descricao);
            Console.WriteLine("Valor: R$" + valor.ToString("C2"));
        }

        ~Produto() { }
    }
}
