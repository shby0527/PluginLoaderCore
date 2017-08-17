using System;

namespace PluginLoader.Plugin
{
    ///<summary>
    /// 通用插件接口
    ///</summary>
    public interface IPlugin
    {
        ///<summary>
        /// 插件真在加载中，在调用构造方法后立即调用
        ///</summary>
        ///<returns>返回true则代表加载成功</returns>
        bool Loading();

        ///<summary>
        /// 加载后调用,在Loading调用返回true后调用
        ///</summary>
        void Loaded();
    }
}