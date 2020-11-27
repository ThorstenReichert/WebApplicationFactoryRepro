using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebApplicationFactoryRepro.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var factory = new WebApplicationFactory<WebApp.Startup>();

            _ = factory.Server;
        }
    }
}
