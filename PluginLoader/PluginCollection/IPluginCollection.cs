using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using PluginLoader.Plugin.Common;

namespace PluginLoader.PluginCollection
{
    /// <summary>
    /// 插件集合
    /// </summary>
    public interface IPluginCollection<out T> : IEnumerable<T>, IEnumerable
        where T : class, IPlugin
    {
        T this[int index] { get; }

        T this[string name] { get; }

        uint Count { get; }
    }
}
