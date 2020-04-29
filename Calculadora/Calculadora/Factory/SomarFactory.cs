using CalculadoraUsandoDelegate.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraUsandoDelegate.Factory
{
    public class SomarFactory : IOperacaoFactory
    {
        private decimal _numero1 { get; set; }
        private decimal _numero2 { get; set; }

        public SomarFactory(decimal Numero1, decimal Numero2)
        {
            _numero1 = Numero1;
            _numero2 = Numero2;
        }

        public IOperacao CriarOperacao()
        {
            IOperacao operacao = new Somar(_numero1, _numero2);

            return operacao;
        }
    }
}
