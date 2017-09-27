using System;

namespace PluginLoader.Plugin.Common
{
    /// <summary>
    /// 插件加载抽象父接口
    /// </summary>
    public interface IPluginFactory
    {
        /// <summary>
        /// 创建插件实例
        /// </summary>
        /// <param name="plugin">插件类型</param>
        /// <returns>插件实例</returns>
        IPlugin CreateInstance(Type plugin);
    }
}
