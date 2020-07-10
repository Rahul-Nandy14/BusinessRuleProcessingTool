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

        [TestMethod]
        public void ShouldReturnVideoLearningToSkiSlipOnly()
        {
            var result = OrderProcessor.ConvertInputToType(new string[] { "video", "Random" });
            Assert.AreEqual("Random", result.ItemName);
            Assert.AreEqual("Generated a packing slip.", result.Operations[0]);
            Assert.AreEqual(1, result.Operations.Count);
        }

        [TestMethod]
        public void ShouldReturnMembershipSlip()
        {
            var result = OrderProcessor.ConvertInputToType(new string[] { "video", "Learning To Ski" });
            Assert.AreEqual("Learning To Ski", result.ItemName);
            Assert.AreEqual("Generated a packing slip.", result.Operations[0]);
            Assert.AreEqual("'First Aid' video added to the packing slip", result.Operations[1]);
            Assert.AreEqual(2, result.Operations.Count);

        }
    }
}
