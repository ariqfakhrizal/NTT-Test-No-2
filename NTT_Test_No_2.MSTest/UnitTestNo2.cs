namespace NTT_Test_No_2.MSTest
{
    [TestClass]
    public class UnitTestNo2
    {

        [TestMethod]
        [DataRow(1, 21, 3)]
        public void SoalRandom_FunctionHitung_ReturnTrue(int numberEnteredTestX, int numberEnteredTestY, int numberEnteredTestZ)
        {
            var actualResult = NTT.NTT_Test_No_2.functionHitung(numberEnteredTestX, numberEnteredTestY, numberEnteredTestZ);
            string expectedResult = "3, 6, 9, 12, 15, 18, 21";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataRow(1, 15, 3)]
        public void SoalA_FunctionHitung_ReturnTrue(int numberEnteredTestX, int numberEnteredTestY, int numberEnteredTestZ)
        {
            var actualResult = NTT.NTT_Test_No_2.functionHitung(numberEnteredTestX, numberEnteredTestY, numberEnteredTestZ);
            string expectedResult = "3, 6, 9, 12, 15";
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}