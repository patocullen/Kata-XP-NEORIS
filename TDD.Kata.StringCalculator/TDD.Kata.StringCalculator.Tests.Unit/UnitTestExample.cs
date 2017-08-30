using Xunit;
using TDD.Kata.StringCalculator;

namespace TDD.Kata.StringCalculator.Tests.Unit
{
    public class UnitTestExample
    {
        private StringCalculator Target;

        public UnitTestExample()
        {
            this.Target = new StringCalculator();
        }

        [Fact]
        public void WhenISendEmptyStringReturnZero()
        {
            //Arrange
            string input = string.Empty;

            //Act
            int output = this.Target.Add(input);

            //Assert
            Assert.Equal(0, output);
        }
    }
}
