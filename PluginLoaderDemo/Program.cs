using System;
using System.Reflection;

using PluginLoader.Plugin.Common;
using PluginLoader.Attributes;
using PluginLoader.Extentions;

namespace PluginLoaderDemo
{
    //[Plugin("a", "b", "1.2.3.4", IsLazyLoading = true)]
    class Program : IPlugin
    {
        static void Main(string[] args)
        {
            IPlugin plugin = new Program();
            var t = plugin.GetPluginVersion();
            var a = plugin.GetPluginName();
            var b = plugin.GetPluginAuthorName();
            Console.ReadKey();
        }

        public void Loaded()
        {
            throw new NotImplementedException();
        }

        public bool Loading(params object[] args)
        {
            throw new NotImplementedException();
        }
    }
}
