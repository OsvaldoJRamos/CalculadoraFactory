using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraUsandoDelegate.Entidades
{
    public class Somar : IOperacao
    {
        private decimal _numero1 { get; set; }
        private decimal _numero2 { get; set; }

        private Somar() { }

        public Somar(decimal Numero1, decimal Numero2)
        {
            _numero1 = Numero1;
            _numero2 = Numero2;
        }

        public decimal ExecutaCalculo()
        {
            return _numero1 + _numero2;
        }
    }
}
