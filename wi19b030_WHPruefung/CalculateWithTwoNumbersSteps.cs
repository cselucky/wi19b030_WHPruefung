using System;
using TechTalk.SpecFlow;
using Xunit;

namespace wi19b030_WHPruefung
{
    [Binding]
    public class CalculateWithTwoNumbersSteps
    {
        int first, second, result;
        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            first = p0;
        }
        
        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            second = p0;
        }
        
        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            result = first + second;
        }
        
        [When(@"the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            result = first * second;
        }
        
        [When(@"the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            result = first - second;
        }
        
        [When(@"the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            result = first / second;
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            var expected = p0;
            var actual = result;
            Assert.Equal(expected, actual);

        }
    }
}
