using System;
using System.Collections.Generic;
using System.Text;

using PluginLoader.Plugin.Common;

namespace PluginLoader.PluginInfo
{
    internal sealed class LazyLoadingInfo : PluginInfo
    {
        public LazyLoadingInfo(Type plugin, IPluginFactory factory)
            : base(plugin, factory)
        {
        }

        public override T CreateInstance<T>()
        {
            IPluginFactory factory = this.GetPluginFactory();
            IPlugin plugin = factory.CreateInstance(this.PluginType);
            if (plugin is T)
                return (T)plugin;
            return default(T);
        }
    }
}
