using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestForPracticeExercises
{
    [TestClass]
    public class UnitTestExercise1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange

            var user = new Person()
            {
                Name = "John Fleming"
            };

            var result = ($"Hello: \n{user.Name}");

            // Act

            //user.Name = "John Fleming";

            // Assert

            Assert.AreEqual("Hello: John Fleming", result);

        }
    }
}
