using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
namespace TestFareySeq
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestMethod1()
        {
            var sequence = new FareySeqAlgo();
            //Format Exception for a negative number
            sequence.getFareySeqForNumber(-1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var sequence = new FareySeqAlgo();
            Regex regex = new Regex(@"{([0-9]\/[0-9],[ ])+([0-9]\/[0-9])}");
            //sample {0/1, 1/4, 1/3, 1/2, 2/3, 3/4, 1/1}
            Match match = regex.Match(sequence.getFareySeqForNumber(4));
            Assert.IsTrue(match.Success);
        }
    }
}
