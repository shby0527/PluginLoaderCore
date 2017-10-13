using System;
using System.Collections.Generic;
using System.Text;
using PluginLoader.Plugin.Common;

namespace PluginLoader.PluginInfo
{
    internal sealed class EarisPluginInfo : PluginInfo
    {
        private IPlugin _plugin = null;
        public EarisPluginInfo(Type plugin, IPluginFactory factory, IPlugin ins)
            : base(plugin, factory)
        {
            _plugin = ins;
        }

        public override T CreateInstance<T>()
        {
            if (_plugin is T)
                return (T)_plugin;
            return default(T);
        }
    }
}
