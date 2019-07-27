using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NunitCase
{
    [TestFixture]
    class Nunit
    {
        [TestCase]
        public void Add()
        {
            TestCase test = new TestCase();
            Assert.AreEqual(50, test.Add(25, 25));
        }
        [TestCase]
        public void Sub()
        {
            TestCase test = new TestCase();
            Assert.AreEqual(15, test.Sub(25, 10));
        }
        [TestCase]
        public void Mul()
        {
            TestCase test = new TestCase();
            Assert.AreEqual(100, test.Mul(25, 4));
        }
        [TestCase]
        public void Div()
        {
            TestCase test = new TestCase();
            Assert.AreEqual(50, test.Div(25, 25));
        }

    }
}
