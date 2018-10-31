using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomNumberDistribution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberDistribution.Tests
{
    [TestClass()]
    public class RNumberTests
    {
        [TestMethod()]
        public void GetDistributedRandomNumberTest()
        {
            RNumber objRNumber = new RNumber();
            string strResult = "1.0,2.0";
            string expected = "0 with " + (1.0 / 3.0) + " probability ,1 with " + (2.0 / 3.0) + " probability ,";
            List<double> ProbTag = strResult.Split(',').Select(double.Parse).ToList();
            
            string actual = objRNumber.GetDistributedRandomNumber(ProbTag);
            actual.Replace(",", System.Environment.NewLine);
            Assert.AreEqual(expected, actual);

        }
    }
}