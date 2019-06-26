using System;
using Xunit;

namespace PracticeExerciseTests
{
    public class Exercise4Tests

    {
        [Fact]
        public void Test1()
        { 
            var container = new NumberContainer
            {
                Number1 = 5,
                Number2 = 6,
            };

            this.Swap(container);

            Assert.Equal(6, container.Number1);
            Assert.Equal(5, container.Number2);
        }

        public void Swap(NumberContainer container)
        {
            int tempNumber = container.Number1;
            container.Number1 = container.Number2;
            container.Number2 = tempNumber; ;
        }

        public class NumberContainer
        {
            public int Number1 { get; set; }
            public int Number2 { get; set; }
        }
    }
}
