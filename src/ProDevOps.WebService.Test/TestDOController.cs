using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProDevOps.WebService.Controller;

namespace ProDevOps.WebService.Test
{
    [TestClass]
    public class TestDOController
    {
        [TestMethod]
        public void GetRandomNumber_ShouldReturnRandomInt() 
        {
            var controller = new DOController();
            var randomNumber = controller.GetRandomNumber();
            Assert.IsTrue(randomNumber <= 100);
        }
    }
}