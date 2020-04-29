using CalculadoraUsandoDelegate.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraUsandoDelegate.Factory
{
    public interface IOperacaoFactory
    {
        IOperacao CriarOperacao();
    }
}
