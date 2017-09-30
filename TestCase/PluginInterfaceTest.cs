using Microsoft.VisualStudio.TestTools.UnitTesting;
using PluginLoader.Extentions;
using System;

namespace TestCase
{
    [TestClass]
    public class PluginInterfaceTest
    {
        [TestMethod]
        public void GetVersion()
        {
            TestPlugin testPlugin = new TestPlugin();
            var ver = testPlugin.GetPluginVersion();
            Version ver2 = new Version(1, 0, 0, 0);
            Assert.AreEqual(ver2, ver);
        }

        [TestMethod]
        public void GetPluginName()
        {
            TestPlugin testPlugin = new TestPlugin();
            var name = testPlugin.GetPluginName();
            Assert.AreEqual("Test", name);
        }

        [TestMethod]
        public void GetPluginAuthorName()
        {
            TestPlugin testPlugin = new TestPlugin();
            var name = testPlugin.GetPluginAuthorName();
            Assert.AreEqual("TestCase", name);
        }
    }
}
