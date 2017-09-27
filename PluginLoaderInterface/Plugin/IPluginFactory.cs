using System;

using PluginLoader.Plugin.Common;

namespace PluginLoader.Plugin
{
    ///<summary>
    ///用来构造<typeparamref name="T" />实例
    ///</summary>
    ///<typeparam name="T">待构造的插件参数</typeparam>
    public interface IPluginFactory<out T> : IPluginFactory
        where T : IPlugin
    {
        ///<summary>
        /// 创建实例
        ///</summary>
        ///<returns>
        ///返回<typeparamref name="T" />实例 
        ///</returns>
        T CreateInstance();
    }
}