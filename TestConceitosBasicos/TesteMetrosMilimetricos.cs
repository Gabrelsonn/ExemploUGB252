using ConceitosBasicos.uteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConceitosBasicos
{
    [TestClass]
    public class TesteMetrosMilimetricos
    {
        [TestMethod]
        public void TesteConverter()
        {
            //cenário

            int M1 = 8;
            int milimetros;

            //ação

            milimetros = MetrosMilimetricos.Converter(8000);

            //verificação

            Assert.AreEqual(8000000, milimetros);
        }

    }
}
