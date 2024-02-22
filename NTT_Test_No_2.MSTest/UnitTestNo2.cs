namespace NTT_Test_No_2.MSTest
{
    [TestClass]
    public class UnitTestNo2
    {

        [TestMethod]
        public void FunctionHitung_ReturnTrue()
        {
            int x = 1;
            int y = 21;
            int z = 3;

            var result = NTT.NTT_Test_No_2.functionHitung(x,y,z);
            Assert.AreEqual("3, 6, 9, 12, 15, 18, 21", result);
        }
    }
}