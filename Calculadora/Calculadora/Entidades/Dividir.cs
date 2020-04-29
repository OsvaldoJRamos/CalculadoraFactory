using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraUsandoDelegate.Entidades
{
    public class Dividir : IOperacao
    {
        private decimal _numero1 { get; set; }
        private decimal _numero2 { get; set; }

        private Dividir() { }

        public Dividir(decimal Numero1, decimal Numero2)
        {
            _numero1 = Numero1;
            _numero2 = Numero2;
        }

        public decimal ExecutaCalculo()
        {
            return _numero1 / _numero2;
        }
    }
}
