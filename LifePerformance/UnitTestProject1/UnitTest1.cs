using System;
using LifePerformance.Classen;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Project()
        {
            Project project = new Project("gebied", false, new Kaart(1, "naam", "locatie"));

            Assert.AreEqual("gebied", project.GebiedNaam);
            Assert.AreEqual(false, project.Afgerond);
            Assert.AreEqual(new Kaart(1, "naam", "locatie"), project.GebiedNaam);
        }
    }
}
