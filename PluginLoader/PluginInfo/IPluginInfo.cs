using System;
using System.Collections.Generic;
using System.Text;

using PluginLoader.Plugin.Common;

namespace PluginLoader.PluginInfo
{
    /// <summary>
    /// 懒加载插件信息
    /// </summary>
    public interface IPluginInfo
    {
        /// <summary>
        /// 插件类型
        /// </summary>
        Type PluginType { get; }

        /// <summary>
        /// 插件名
        /// </summary>
        string Name { get; }

        /// <summary>
        /// 插件作者
        /// </summary>
        string Author { get; }

        /// <summary>
        /// 插件版本
        /// </summary>
        Version Version { get; }

        /// <summary>
        /// 获取插件构建工厂
        /// </summary>
        /// <typeparam name="T">插件父类类型</typeparam>
        /// <returns></returns>
        IPluginFactory<T> GetPluginFactory<T>() where T : class, IPlugin;

        /// <summary>
        /// 获取插件构建工厂
        /// </summary>
        /// <returns></returns>
        IPluginFactory GetPluginFactory();

        /// <summary>
        /// 创建插件
        /// </summary>
        /// <returns></returns>
        T CreateInstance<T>() where T : IPlugin;
    }
}
