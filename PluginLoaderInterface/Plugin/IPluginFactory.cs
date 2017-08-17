using System;

namespace PluginLoader.Plugin
{
    ///<summary>
    ///用来构造<typeparamref name="T" />实例
    ///</summary>
    ///<typeparam name="T">待构造的插件参数</typeparam>
    public interface IPluginFactory<out T> where T : IPlugin
    {
        ///<summary>
        /// 创建实例
        ///</summary>
        ///<param name="type">
        ///待构造的实例类型
        ///</param>
        ///<returns>
        ///返回<typeparamref name="T" />实例 
        ///</returns>
        T CreateInstance(Type type);
    }
}