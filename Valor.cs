using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCalisthenics
{
    internal class Valor
    {
        public string Valor { get; private set; }

        public Valor(decimal valor)
        {
            SetValor(valor);
        }

        private void SetValor(string valor)
        {
            if (!ValidarValor.IsValorValido(valor))
                throw new ArgumentException("Valor Não pode ser 0 ou menor");

            Valor = valor;
        }
    }
}
