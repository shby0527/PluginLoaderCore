using Microsoft.VisualStudio.TestTools.UnitTesting;
using PluginLoader.Extentions;
using PluginLoader.Util;
using PluginLoader.Plugin;
using PluginLoader.Plugin.Common;
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

        [TestMethod]
        public void UtilCheckImplementTest()
        {
            Type implemented = typeof(TestPlugin);
            Type notimplemented = typeof(EntryPointNotFoundException);
            Assert.AreEqual(PluginUtil.CheckImplement(implemented), true);
            Assert.AreEqual(PluginUtil.CheckImplement(notimplemented), false);
        }

        [TestMethod]
        public void UtilPluginTest()
        {
            IPluginFactory<SamplePluginBase> factory = new DefaultPluginFactory();
            IPluginFactory factory1 = factory;
            IPlugin plugin = factory1.CreateInstance(typeof(TestPlugin));
            SamplePluginBase pluginBase = factory.CreateInstance(typeof(TestPlugin));
            Assert.IsNotNull(plugin);
            Assert.IsNotNull(pluginBase);
        }
    }
}
