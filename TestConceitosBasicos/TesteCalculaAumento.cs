using ConceitosBasicos.uteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConceitosBasicos
{
    [TestClass]
    public class TesteCalculaAumento
    {
        [TestMethod]
        public void TesteAumentodoV()
        {
            //cenário
            decimal salario = 10000;
            float percentual = 54;
            decimal resultado;
            CalculaAumento calculaAumento = new CalculaAumento();
            //ação
            resultado = calculaAumento.AumentodoV(salario, percentual);

            //verificação
            Assert.AreEqual(5400, resultado);
        }
    }
}
