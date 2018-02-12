using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyNameWCFservice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNameWCFservice.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void GetNameTest()
        {
            //arrange
            var service1 =new Service1();

            //act
            string name = service1.GetName();

            //assert
            Assert.AreEqual("Allan", name);
        }

        [TestMethod()]
        public void GetMyEmailTest()
        {
            //arrange
            var service1 = new Service1();

            //act
            string email = service1.GetMyEmail();

            //assert
            Assert.AreEqual("alla2653@easj.edu.dk", email);
        }
    }
}