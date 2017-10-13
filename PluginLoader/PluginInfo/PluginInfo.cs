using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;


using PluginLoader.Plugin.Common;
using PluginLoader.Util;

namespace PluginLoader.PluginInfo
{
    internal abstract class PluginInfo : IPluginInfo
    {
        private IPluginFactory _factory = null;

        public Type PluginType { get; }

        public string Name { get; }

        public string Author { get; }

        public Version Version { get; }

        protected PluginInfo(Type plugin, IPluginFactory factory)
        {
            PluginType = plugin;
            Name = PluginUtil.GetPluginAttribute(plugin).PluginName;
            Author = PluginUtil.GetPluginAttribute(plugin).Author;
            Version = PluginUtil.GetPluginAttribute(plugin).Version;
            _factory = factory;
        }

        public abstract T CreateInstance<T>() where T : IPlugin;

        public IPluginFactory GetPluginFactory()
        {
            return _factory;
        }

        IPluginFactory<T> IPluginInfo.GetPluginFactory<T>()
        {
            if (_factory is IPluginFactory<T>)
                return (IPluginFactory<T>)_factory;
            return null;
        }
    }
}
