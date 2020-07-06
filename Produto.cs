using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCalisthenics
{
    internal class Produto
    {
        public Guid Id { get; private set; }
        private Descricao Descricao { get; set; }
        private Valor Valor { get; set; }

        public Produto(string descricao, decimal valor)
        {
            Id = Guid.NewGuid();
            Descricao = new Descricao(descricao);
            Valor = new Valor(valor);
        }

        public string GetDescricao()
            => Descricao.ValorDescricao;

        public string GetValor()
            => Valor.Valor;
    }
}
