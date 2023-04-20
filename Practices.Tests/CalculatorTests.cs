using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Multiplication_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();

            Assert.That(calculator.Multiplication(8, 2) == 16);
        }

        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();

            Assert.That(calculator.Subtraction(8, 2) == 6);
        }

        [Test]
        public void Division__MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();

            Assert.That(calculator.Division(8, 2) == 4);
        }

        [Test]
        public void Division_MustThrowException()
        {
            Calculator calculator = new Calculator();

            Assert.Throws<DivideByZeroException>(() => calculator.Division(8, 0));
        }

        [Test]
        public void Addition__MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();

            Assert.That(calculator.Addition(8, 2) == 10);
        }

        
    }
}
