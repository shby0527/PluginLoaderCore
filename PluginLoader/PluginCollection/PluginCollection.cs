using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;

using PluginLoader.Plugin.Common;
using PluginLoader.PluginInfo;
using PluginLoader.Util;

namespace PluginLoader.PluginCollection
{
    /// <summary>
    /// 插件集合
    /// </summary>
    [DebuggerDisplay("PluginCount={Count}")]
    internal class PluginCollection : IPluginCollection<IPlugin>
    {
        private List<IPluginInfo> _list = null;

        public PluginCollection()
        {
            _list = new List<IPluginInfo>();
        }

        public IPlugin this[int index]
        {
            get
            {
                return _list[index].CreateInstance<IPlugin>();
            }
        }

        public IPlugin this[string name]
        {
            get
            {
                var plugin = from p in _list where p.Name == name select p;
                if (plugin.Any())
                {
                    var outplugin = plugin.First();
                    return outplugin.CreateInstance<IPlugin>();
                }
                return null;
            }
        }

        public uint Count => Convert.ToUInt32(_list.Count);

        public IEnumerator<IPlugin> GetEnumerator()
        {
            foreach (var i in _list)
            {
                yield return i.CreateInstance<IPlugin>();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var item in _list)
            {
                yield return item.CreateInstance<IPlugin>();
            }
        }

        public void Add(IPluginInfo info)
        {
            if (IsExists(info.Name))
                return;
            _list.Add(info);
        }

        public bool IsExists(string name)
        {
            var rt = from p in _list where p.Name == name select p;
            if (rt.Any())
                return true;
            return false;
        }
    }
}