using System;
using ReturnPolicy;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace RETURN_POLICY_UnitTest
{
    [TestClass]
    public class ReturnPolicyTest
    {
        [TestMethod]
        public void VerifyReturnPolicy()
        {
        //ARRANGE
            var ReturnPolicyClass1 = new ReturnPolicyClass1() ;

    //ACT
        var returnWindow = ReturnPolicyClass1.GetReturnWindow();
        var refundProcess = ReturnPolicyClass1.GetRefundProcess();

    //ASSERT
        Assert.AreEqual("30 days", returnWindow);
        Assert.AreEqual("Full refund", refundProcess);
        }
    }
}
