using System.Collections.Generic;
using Xunit;
using xUnitTutorial.Service;

namespace xUnitTutorial.unitTests.Service
{
    public class CalculatorTests
    {
        private readonly Calculator _sut;

        public CalculatorTests()
        {
            _sut = new Calculator();
        }

        [Fact(Skip = "This test is replaced by the one below")]
        public void AddTwoNumbers()
        {
            _sut.Add(5);
            _sut.Add(8);
            Assert.Equal(13, _sut.Value);
        }

        [Theory]
        [InlineData(13, 5, 8)]
        [InlineData(0, -3, 3)]
        [InlineData(0, 0, 0)]
        public void AddTwoNumbersTheory(decimal expected, decimal num1, decimal num2)
        {
            _sut.Add(num1);
            _sut.Add(num2);
            Assert.Equal(expected, _sut.Value);
        }
        
        [Theory]
        [MemberData(nameof(TestData))]
        public void AddManyNumbersTheory(decimal expected, params decimal[] values)
        {
            foreach (var value in values)
            {
                _sut.Add(value);
            }

            Assert.Equal(expected, _sut.Value);
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] {15, new decimal[] {10, 5}};
            yield return new object[] {15, new decimal[] {5, 5, 5}};
            yield return new object[] {-20, new decimal[] {-10, -30, 20}};
        }
        
    }
}