using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fractions;

namespace FractionTests
{
    [TestClass]
    public class AllTests
    {
        [TestMethod]
        public void AdditionTest_1()
        {
            Fraction left  = new Fraction(  "5/9");
            Fraction right = new Fraction(  "9/5");
            Fraction sum   = new Fraction("106/45");
            Assert.AreEqual(left + right, sum);
        }

        [TestMethod]
        public void AdditionTest_2()
        {
            Fraction left  = new Fraction( "2/7");
            Fraction right = new Fraction( "1/8");
            Fraction sum   = new Fraction("23/56");
            Assert.AreEqual(left + right, sum);
        }

        [TestMethod]
        public void AdditionTest_3()
        {
            Fraction left  = new Fraction( "-4/1");
            Fraction right = new Fraction(  "1/4");
            Fraction sum   = new Fraction("-15/4");
            Assert.AreEqual(left + right, sum);
        }

        [TestMethod]
        public void AdditionTest_4()
        {
            Fraction left  = new Fraction("-4/0");
            Fraction right = new Fraction( "1/4");
            Assert.ThrowsException<DivideByZeroException>(() =>  left + right , "");  //  Why is no exception thrown during unit testing, even though it is thrown in normal program execution?  See Program.cs.  I will ask in class.
        }

        [TestMethod]
        public void AdditionTest_5()
        {
            Fraction left  = new Fraction(   "-42/17");
            Fraction right = new Fraction(  "-894/893");
            Fraction sum   = new Fraction("-52704/15181");
            Assert.AreEqual(left + right, sum);
        }

        [TestMethod]
        public void AdditionTest_6()
        {
            Fraction left  = new Fraction("0/1");
            Fraction right = new Fraction("0/2");
            Fraction sum   = new Fraction("0/1");
            Assert.AreEqual(left + right, sum);
        }

        [TestMethod]
        public void AdditionTest_7()
        {
            Fraction left  = new Fraction("0/0");
            Fraction right = new Fraction("0/2");
            Assert.ThrowsException<DivideByZeroException>(() => left + right, "");
        }



        [TestMethod]
        public void SubtractionTest_1()
        {
            Fraction left       = new Fraction(  "5/9");
            Fraction right      = new Fraction(  "9/5");
            Fraction difference = new Fraction("-56/45");
            Assert.AreEqual(left - right, difference);
        }

        [TestMethod]
        public void SubtractionTest_2()
        {
            Fraction left       = new Fraction("2/7");
            Fraction right      = new Fraction("1/8");
            Fraction difference = new Fraction("9/56");
            Assert.AreEqual(left - right, difference);
        }

        [TestMethod]
        public void SubtractionTest_3()
        {
            Fraction left       = new Fraction( "-4/1");
            Fraction right      = new Fraction(  "1/4");
            Fraction difference = new Fraction("-17/4");
            Assert.AreEqual(left - right, difference);
        }

        [TestMethod]
        public void SubtractionTest_4()
        {
            Fraction left       = new Fraction( "-4/0");
            Fraction right      = new Fraction(  "1/4");
            Assert.ThrowsException<DivideByZeroException>(() => left - right, "");
        }

        [TestMethod]
        public void SubtractionTest_5()
        {
            Fraction left       = new Fraction("-42/17");
            Fraction right      = new Fraction("-894/893");
            Fraction difference = new Fraction("-22308/15181");
            Assert.AreEqual(left - right, difference);
        }

        [TestMethod]
        public void SubtractionTest_6()
        {
            Fraction left       = new Fraction("0/1");
            Fraction right      = new Fraction("0/2");
            Fraction difference = new Fraction("0/1");
            Assert.AreEqual(left - right, difference);
        }

        [TestMethod]
        public void SubtractionTest_7()
        {
            Fraction left       = new Fraction("0/0");
            Fraction right      = new Fraction("0/2");
            Assert.ThrowsException<DivideByZeroException>(() => left - right, "");
        }



        [TestMethod] 
        public void MultiplicationTest_1()
        {
            Fraction left = new Fraction("5/9");
            Fraction right = new Fraction("9/5");
            Fraction product = new Fraction("1/1");
            Assert.AreEqual(left * right, product);
        }

        [TestMethod]
        public void MultiplicationTest_2()
        {
            Fraction left = new Fraction("2/7");
            Fraction right = new Fraction("1/8");
            Fraction product = new Fraction("2/56");
            Assert.AreEqual(left * right, product);
        }

        [TestMethod]
        public void MultiplicationTest_3()
        {
            Fraction left = new Fraction("-4/1");
            Fraction right = new Fraction("1/4");
            Fraction product = new Fraction("-1/1");
            Assert.AreEqual(left * right, product);
        }

        [TestMethod]
        public void MultiplicationTest_4()
        {
            Fraction left = new Fraction("-4/0");
            Fraction right = new Fraction("1/4");
            Assert.ThrowsException<DivideByZeroException>(() => left * right, "");
        }

        [TestMethod]
        public void MultiplicationTest_5()
        {
            Fraction left = new Fraction("-42/17");
            Fraction right = new Fraction("-894/893");
            Fraction product = new Fraction("37548/15181");
            Assert.AreEqual(left * right, product);
        }

        [TestMethod]
        public void MultiplicationTest_6()
        {
            Fraction left = new Fraction("0/1");
            Fraction right = new Fraction("0/2");
            Fraction product = new Fraction("0/1");
            Assert.AreEqual(left * right, product);
        }

        [TestMethod]
        public void MultiplicationTest_7()
        {
            Fraction left = new Fraction("0/0");
            Fraction right = new Fraction("0/2");
            Assert.ThrowsException<DivideByZeroException>(() => left * right, "");
        }


        [TestMethod]
        public void DivisionTest_1()
        {
            Fraction left = new Fraction("5/9");
            Fraction right = new Fraction("9/5");
            Fraction quotient = new Fraction("25/81");
            Assert.AreEqual(left / right, quotient);
        }

        [TestMethod]
        public void DivisionTest_2()
        {
            Fraction left = new Fraction("2/7");
            Fraction right = new Fraction("1/8");
            Fraction quotient = new Fraction("16/7");
            Assert.AreEqual(left / right, quotient);
        }

        [TestMethod]
        public void DivisionTest_3()
        {
            Fraction left = new Fraction("-4/1");
            Fraction right = new Fraction("1/4");
            Fraction quotient = new Fraction("-16/1");
            Assert.AreEqual(left / right, quotient);
        }

        [TestMethod]
        public void DivisionTest_4()
        {
            Fraction left = new Fraction("-4/0");
            Fraction right = new Fraction("1/4");
            Assert.ThrowsException<DivideByZeroException>(() => left / right, "");
        }

        [TestMethod]
        public void DivisionTest_5()
        {
            Fraction left = new Fraction("-42/17");
            Fraction right = new Fraction("-894/893");
            Fraction quotient = new Fraction("37506/15198");
            Assert.AreEqual(left / right, quotient);
        }

        [TestMethod]
        public void DivisionTest_6()
        {
            Fraction left = new Fraction("0/1");
            Fraction right = new Fraction("0/2");
            Assert.ThrowsException<DivideByZeroException>(() => left / right, "");
        }

        [TestMethod]
        public void DivisionTest_7()
        {
            Fraction left = new Fraction("0/0");
            Fraction right = new Fraction("0/2");
            Assert.ThrowsException<DivideByZeroException>(() => left / right, "");
        }



        [TestMethod]
        public void GreaterThanTest_1()
        {
            Fraction left = new Fraction("5/9");
            Fraction right = new Fraction("9/5");
            Assert.AreEqual(left > right, false);
        }

        [TestMethod]
        public void GreaterThanTest_2()
        {
            Fraction left = new Fraction("2/7");
            Fraction right = new Fraction("1/8");
            Assert.AreEqual(left > right, true);
        }

        [TestMethod]
        public void GreaterThanTest_3()
        {
            Fraction left = new Fraction("-4/1");
            Fraction right = new Fraction("1/4");
            Assert.AreEqual(left > right, false);
        }

        [TestMethod]
        public void GreaterThanTest_4()
        {
            Fraction left = new Fraction("-4/0");
            Fraction right = new Fraction("1/4");
            Assert.ThrowsException<DivideByZeroException>(() => left > right, "");
        }

        [TestMethod]
        public void GreaterThanTest_5()
        {
            Fraction left = new Fraction("-42/17");
            Fraction right = new Fraction("-894/893");
            Assert.AreEqual(left > right, false);
        }

        [TestMethod]
        public void GreaterThanTest_6()
        {
            Fraction left = new Fraction("0/1");
            Fraction right = new Fraction("0/2");
            Assert.AreEqual(left > right, false);
        }

        [TestMethod]
        public void GreaterThanTest_7()
        {
            Fraction left = new Fraction("0/0");
            Fraction right = new Fraction("0/2");
            Assert.ThrowsException<DivideByZeroException>(() => left > right, "");
        }



        [TestMethod]
        public void LessThanTest_1()
        {
            Fraction left = new Fraction("5/9");
            Fraction right = new Fraction("9/5");
            Assert.AreEqual(left < right, true);
        }

        [TestMethod]
        public void LessThanTest_2()
        {
            Fraction left = new Fraction("2/7");
            Fraction right = new Fraction("1/8");
            Assert.AreEqual(left < right, false);
        }

        [TestMethod]
        public void LessThanTest_3()
        {
            Fraction left = new Fraction("-4/1");
            Fraction right = new Fraction("1/4");
            Assert.AreEqual(left < right, true);
        }

        [TestMethod]
        public void LessThanTest_4()
        {
            Fraction left = new Fraction("-4/0");
            Fraction right = new Fraction("1/4");
            Assert.ThrowsException<DivideByZeroException>(() => left < right, "");
        }

        [TestMethod]
        public void LessThanTest_5()
        {
            Fraction left = new Fraction("-42/17");
            Fraction right = new Fraction("-894/893");
            Assert.AreEqual(left < right, true);
        }

        [TestMethod]
        public void LessThanTest_6()
        {
            Fraction left = new Fraction("0/1");
            Fraction right = new Fraction("0/2");
            Assert.AreEqual(left < right, false);
        }

        [TestMethod]
        public void LessThanTest_7()
        {
            Fraction left = new Fraction("0/0");
            Fraction right = new Fraction("0/2");
            Assert.ThrowsException<DivideByZeroException>(() => left < right, "");
        }

    }
}
