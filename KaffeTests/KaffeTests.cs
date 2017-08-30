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
    public class KaffeTests
    {
        [TestMethod()]
        public void prisTestKaffe()
        {
            //Arrange
            var kaffe = new SortKaffe();
            //Act
            int pris = kaffe.Pris();
            //Assert
            Assert.AreEqual(20, pris);


        }
        [TestMethod()]
        [ExpectedException((typeof(ArgumentException)))]
        public void prisTestKaffeForMegetRabat20kr()
        {
            //Arrange
            var kaffe = new SortKaffe(20);
            //Act
            int pris = kaffe.Pris();
            //Assert


        }

        [TestMethod()]
        [ExpectedException((typeof(ArgumentException)))]
        public void prisTestKaffeForMegetRabat21kr()
        {
            //Arrange
            var kaffe = new SortKaffe(21);
            //Act
            int pris = kaffe.Pris();
            //Assert


        }
        [TestMethod()]
        public void styrkeTestKaffe()
        {
            //Arrange
            var kaffe = new SortKaffe();
            //Act
            //string styrke = kaffe.styrke();
            ////Assert
            //Assert.AreEqual("stærk", styrke);
        }
        public void TestKaffeListe()
        {
            //Arrange
            var kaffeListe = new List<IMælk>();

            var cortado = new CortadoKaffe();
            var latte = new Latte();
            var sortKaffe = new SortKaffe();
            kaffeListe.Add(cortado);
            kaffeListe.Add(latte);
            // kaffeliste.Add(sortKaffe);
            int total = 0;
            foreach (var kaffeitem in kaffeListe)
            {
                total += kaffeitem.MlMælk();
                //if (kaffeitem is CortadoKaffe)
                //{
                //    var localCortado = kaffeitem as CortadoKaffe;
                //}
                //kaffeitem.MlMælk();
            }
            //Assert
            Assert.AreEqual(145, total);
        }
    }
}