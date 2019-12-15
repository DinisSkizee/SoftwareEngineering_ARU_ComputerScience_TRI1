using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DinisTest
{
    [TestClass]
    public class UnitTestDinis
    {
        [TestMethod]
        public void TestMethod1()
        {

            // Arrange
            int success = 1;
            int unitTest;
            string user = "admin";
            string pass = "pass";

            // Act
            if (user == "admin" && pass == "admin")
            {
                unitTest = 1;
            }
            else
            {
                unitTest = 0;
            }

            // Assert
            Assert.AreEqual(success, unitTest);
        }
    }
}
