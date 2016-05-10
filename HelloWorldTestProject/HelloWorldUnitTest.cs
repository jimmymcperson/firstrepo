using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldTestProject
{
    [TestClass]
    public class HelloWorldUnitTest
    {
        [TestMethod]
        public void HelloWorldToConsoleTestMethod()
        {
            // Arrange
            string expectedResult = "Hello, World!";

            // Act
            string result = COMP123_S2016_Lesson1.Program.HelloWorldToConsole();

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
