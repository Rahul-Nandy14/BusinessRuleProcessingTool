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
            Video v = new Video("Learning To Ski");
            Assert.AreEqual("abcd", v.ItemName);
            Assert.AreEqual("Generated a packing slip.", v.Operations[0]);
            Assert.AreEqual(2, v.Operations.Count);
        }

        [TestMethod]
        public void ShouldReturnMembershipSlip()
        {
            Membership m = new Membership();
            Assert.AreEqual(3, m.Operations.Count);

        }
    }
}
