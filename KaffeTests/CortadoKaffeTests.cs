using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kaffe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffe.Tests
{
    [TestClass()]
    public class CortadoKaffeTests
    {
        [TestMethod()]
        public void prisTest()
        {
            //Arrange
            var kaffe = new CortadoKaffe();
            //Act
            int pris = kaffe.Pris();
            //Assert
            Assert.AreEqual(25, pris);
        }
    }
}