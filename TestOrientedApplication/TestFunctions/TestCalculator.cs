namespace TestOrientedApplication.TestFunctions;

public class TestCalculator
{

    [TestClass]
    public class Calculator
    {
        /*
         *  
         *
         */
        [TestMethod]
        public void SumTest()
        {
            Calculator calculator = new Calculator();

            int result = calculator.Sum(3, 5);

            Assert.AreEqual(8, result);
        }
    }

}
