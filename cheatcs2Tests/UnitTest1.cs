using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PredictorApp;
using cheatcs2;
namespace cheatcs2Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetPredictionX_Test_Da_100_DaReturned()
        {
            //исходные данные
            string inputString = "Да";
            double probable = 1.0;
            string expected = "Да";

            //полученные 
            Predictor predictor = new Predictor();
            string actual = predictor.ProbabilityX(inputString, probable);

            //сравнение
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EquallyProbability_Test()
        {
            //исходные данные
            string inputString = "Да";
            double probable = 1.0;
            string expected = "Да";

            //полученные 
            Predictor predictor = new Predictor();
            string actual = predictor.ProbabilityX(inputString, probable);

            //сравнение
            Assert.AreEqual(expected, actual);
        }
    }
}
