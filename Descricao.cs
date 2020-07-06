using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCalisthenics
{
    internal class Descricao
    {
        public string ValorDescricao{ get; private set; }

        public Descricao (string valorDescricao)
        {
            SetDescricao (valorDescricao);
        }

        private void SetDescricao(string valorDescricao)
        {
            if (string.IsNullOrWhiteSpace(valorDescricao))
                throw new ArgumentException("Descrição Não pode ser  Vazia  !!");

            ValorDescricao = valorDescricao;
        }
    }
}