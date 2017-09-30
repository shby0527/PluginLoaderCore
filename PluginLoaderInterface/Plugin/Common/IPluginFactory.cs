using System;
using System.Collections.Generic;
using System.Text;

namespace PluginLoader.Plugin.Common
{
    /// <summary>
    /// 用来定义如何创建程序集中的插件
    /// </summary>
    public interface IPluginFactory
    {
        /// <summary>
        /// 创建一个实例
        /// </summary>
        /// <param name="plugin">插件类型</param>
        /// <returns>插件实例</returns>
        IPlugin CreateInstance(Type plugin);
    }

    /// <summary>
    /// 用来定义如何创建程序集中的具体插件
    /// </summary>
    public interface IPluginFactory<out T> : IPluginFactory
        where T : IPlugin, new()
    {
        T CreateInstance();
    }
}
