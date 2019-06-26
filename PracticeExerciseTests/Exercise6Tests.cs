using System;
using Xunit;

namespace PracticeExerciseTests
{
    public class Exercise6Tests
    {
        [Fact]
        public void Test1()
        {
            var container = new NumberContainer
            {
                Number1 = 1,
                Number2 = 2,
                Number3 = 3
            };

            this.DoMultiplication(container);

            Assert.Equal(6, container.Result);
        }

        public void DoMultiplication(NumberContainer container)
        {
            container.Result = container.Number1 * container.Number2 * container.Number3;
        }

        public class NumberContainer
        {
            public int Number1 { get; set; }
            public int Number2 { get; set; }
            public int Number3 { get; set; }
            public int Result { get; set; }


        }
    }
}
