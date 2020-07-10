using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProcessingTool;

namespace OrderProcessingToolTest
{
    [TestClass]
    public class OderEngineProcessingUnitTest
    {        
        [TestMethod]
        public void ShouldReturnVideoSlipOnlyFromOderProcessingUnitTest()
        {
            Video v = new Video("abcd");
            Assert.AreEqual("abcd", v.ItemName);
            Assert.AreEqual("Generated a packing slip.", v.Operations[0]);
        }
    }
}
