using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProDevOps.WebService.Controller;

namespace ProDevOps.WebService.Test
{
    [TestClass]
    public class DOControllerTest
    {
        [TestMethod]
        public void ShouldReturnNumberLessThanEQHundrad_GetRandomNumber()
        {
            DOController controller = new DOController();
            var output = controller.GetRandomNumber();
            Assert.IsTrue(output >= 0 && output <= 100);
        }
    }
}
