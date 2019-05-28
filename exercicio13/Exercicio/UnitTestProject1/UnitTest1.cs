using System;
using Exercicio.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//mock
//SOLID

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            Smart.Model.BusinessObject.DbConnAssemblyName = "Exercicio.Conexao";
            Smart.Model.BusinessObject.DbConnClassPath = "Exercicio.Conexao.DbConn";
        }
        [TestMethod]
        public void TestCpfDuplicadoV()
        {
            using (ContatoBLL dd = new ContatoBLL())
            {
                var test = dd;
                bool dd1 = test.ValidaCpf("100");
                Assert.IsTrue(dd1);
            }
        }
        [TestMethod]
        public void TestCpfDuplicadoF()
        {
            using (ContatoBLL dd = new ContatoBLL())
            {
                var test = dd;
                bool dd1 = test.ValidaCpf("11122233321");
                Assert.IsTrue(dd1);
            }
        }

        [TestMethod]
        public void TestIdade()
        {
            var testI = new ContatoBLL();
            bool dd = testI.VerificarIdade(DateTime.Parse("21/08/1995"));
            Assert.IsFalse(dd);
        }
        [TestMethod]
        public void TestIdadeMenor18Ano()
        {
            var testI = new ContatoBLL();
            bool dd = testI.VerificarIdade(DateTime.Parse("21/08/2001"));
            Assert.IsTrue(dd);
        }
        [TestMethod]
        public void TestIdadeMenor18Mes()
        {
            var testI = new ContatoBLL();
            bool dd = testI.VerificarIdade(DateTime.Parse("21/09/2000"));
            Assert.IsTrue(dd);
        }
        [TestMethod]
        public void TestIdadeMenor18MesEdia()
        {
            var testI = new ContatoBLL();
            bool dd = testI.VerificarIdade(DateTime.Parse("24/08/2000"));
            Assert.IsTrue(dd);
        }
        [TestMethod]
        public void TestIdadeMaior60Ano()
        {
            var testI = new ContatoBLL();
            bool dd = testI.VerificarIdade(DateTime.Parse("21/08/1957"));
            Assert.IsTrue(dd);
        }
        [TestMethod]
        public void TestIdadeMenor60Mes()
        {
            var testI = new ContatoBLL();
            bool dd = testI.VerificarIdade(DateTime.Parse("21/07/1958"));
            Assert.IsTrue(dd);
        }
        [TestMethod]
        public void TestIdadeMenor60MesEdia()
        {
            var testI = new ContatoBLL();
            bool dd = testI.VerificarIdade(DateTime.Parse("22/08/1958"));
            Assert.IsTrue(dd);
        }
        [TestMethod]
        public void TestNomeSobrenomeV()
        {
            var testI = new ContatoBLL();
            bool dd = testI.validaNome("vinicius nascimento");
            Assert.IsTrue(dd);
        }
        [TestMethod]
        public void TestNomeSobrenomeF()
        {
            var testI = new ContatoBLL();
            bool dd = testI.validaNome("vinicius");
            Assert.IsFalse(dd);
        }

    }
}
