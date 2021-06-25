using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator.other;

namespace Calculator.Text
{

    //Тесты суммы
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Summa6and2res33()
        {
            double number1 = 6;
            double number2 = 2;
            double Conclusion = 8;

            double btnEqually = Calculat.Plus(number1, number2);

            Assert.AreEqual(Conclusion, btnEqually);
        }
        [TestMethod]
        public void Summa12and7res19()
        {
            double number1 = 12;
            double number2 = 7;
            double Conclusion = 19;

            double btnEqually = Calculat.Plus(number1, number2);

            Assert.AreEqual(Conclusion, btnEqually);
        }
        [TestMethod]
        public void Summa33and22res55()
        {
            double number1 = 33;
            double number2 = 22;
            double Conclusion = 55;

            double btnEqually = Calculat.Plus(number1, number2);

            Assert.AreEqual(Conclusion, btnEqually);
        }
        //тесты разности
        [TestMethod]
        public void Minus15and3res5()
        {
            double number1 = 15;
            double number2 = 3;
            double Conclusion = 12;

            double btnEqually = Calculat.Minus(number1, number2);

            Assert.AreEqual(Conclusion, btnEqually);
        }
        [TestMethod]
        public void Minus100and1res99()
        {
            double number1 = 100;
            double number2 = 1;
            double Conclusion = 99;

            double btnEqually = Calculat.Minus(number1, number2);

            Assert.AreEqual(Conclusion, btnEqually);
        }
        [TestMethod]
        public void Minus74and74res0()
        {
            double number1 = 74;
            double number2 = 74;
            double Conclusion =0;

            double btnEqually = Calculat.Minus(number1, number2);

            Assert.AreEqual(Conclusion, btnEqually);
        }
        //Тесты на умножение
        [TestMethod]
        public void Multiplier20and5res4()
        {
            double number1 = 20;
            double number2 = 5;
            double Conclusion = 100;

            double btnEqually = Calculat.Multiplier(number1, number2);

            Assert.AreEqual(Conclusion, btnEqually);
        }
        [TestMethod]
        public void Multiplier89and6res534()
        {
            double number1 = 89;
            double number2 = 6;
            double Conclusion = 534;

            double btnEqually = Calculat.Multiplier(number1, number2);

            Assert.AreEqual(Conclusion, btnEqually);
        }
        [TestMethod]
        public void Multiplier100and100res10000()
        {
            double number1 = 100;
            double number2 = 100;
            double Conclusion = 10000;

            double btnEqually = Calculat.Multiplier(number1, number2);

            Assert.AreEqual(Conclusion, btnEqually);
        }
        //Тесты на деление
        [TestMethod]
        public void Fission35and7res5()
        {
            double number1 = 35;
            double number2 = 7;
            double Conclusion = 5;

            double btnEqually = Calculat.Fission(number1, number2);

            Assert.AreEqual(Conclusion, btnEqually);
        }
        [TestMethod]
        public void Fission100and100res1()
        {
            double number1 = 100;
            double number2 = 100;
            double Conclusion = 1;

            double btnEqually = Calculat.Fission(number1, number2);

            Assert.AreEqual(Conclusion, btnEqually);
        }
        [TestMethod]
        public void Fission726and11res66()
        {
            double number1 = 726;
            double number2 = 11;
            double Conclusion =66;

            double btnEqually = Calculat.Fission(number1, number2);

            Assert.AreEqual(Conclusion, btnEqually);
        }
    }
}
