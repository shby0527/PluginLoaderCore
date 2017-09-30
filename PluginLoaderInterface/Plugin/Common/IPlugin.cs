using System;

namespace PluginLoader.Plugin.Common
{
    ///<summary>
    /// 通用插件接口
    /// 插件必须保证有一个可以访问的
    /// 无参数构造方法
    ///</summary>
    public interface IPlugin
    {
        ///<summary>
        /// 插件真在加载中，在调用构造方法后立即调用
        ///</summary>
        ///<param name="args">初始化的参数</param>
        ///<returns>返回true则代表加载成功</returns>
        bool Loading(params object[] args);

        ///<summary>
        /// 加载后调用,在Loading调用返回true后调用
        ///</summary>
        void Loaded();

    }
}