using CalculadoraUsandoDelegate.Entidades;
using CalculadoraUsandoDelegate.Enumerador;
using CalculadoraUsandoDelegate.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numero1 = 15, numero2 = 20;
            var tipoOperacao = OperacaoEnum.Somar;

            IOperacaoFactory factory;

            switch (tipoOperacao)
            {
                case OperacaoEnum.Somar:
                    factory = new SomarFactory(numero1, numero2);
                    break;

                case OperacaoEnum.Subtrair:
                    factory = new SubtrairFactory(numero1, numero2);
                    break;

                case OperacaoEnum.Multiplicar:
                    factory = new MultiplicarFactory(numero1, numero2);
                    break;

                case OperacaoEnum.Dividir:
                    factory = new DividirFactory(numero1, numero2);
                    break;

                default:
                    throw new Exception("A operação é inválida!");

            }

            var objetoExecução = factory.CriarOperacao();

            ExecutaOperacao(objetoExecução);

            Console.ReadKey();
        }

        public static void ExecutaOperacao(IOperacao metodo)
        {
            Console.WriteLine(metodo.ExecutaCalculo());
        }
    }
}
