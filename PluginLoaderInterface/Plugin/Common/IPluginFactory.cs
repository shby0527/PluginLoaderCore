using System;


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

        /// <summary>
        /// 创建插件实例并转换成<typeparamref name="T"/>类型
        /// </summary>
        /// <typeparam name="T">输出类型</typeparam>
        /// <param name="plugin">插件类型</param>
        /// <returns></returns>
        T CreateInstance<T>(Type plugin) where T : class, IPlugin;
    }
}
