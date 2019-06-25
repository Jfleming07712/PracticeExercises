using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestForPracticeExercises
{
    [TestClass]
    public class UnitTestForExercise2
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var x = 10;
            var y = 20;

            // Act
            var result = x + y;

            // Assert

            Assert.AreEqual(30, result);

        }
    }
}
