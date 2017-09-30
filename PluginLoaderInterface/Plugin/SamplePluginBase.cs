using System;

using PluginLoader.Plugin.Common;

namespace PluginLoader.Plugin
{
    ///<summary>
    /// 默认插件基类
    ///</summary>
    public abstract class SamplePluginBase : IPlugin
    {

        protected SamplePluginBase()
        {

        }

        public virtual bool Loading(params object[] args)
        {
            throw new NotSupportedException();
        }

        public virtual void Loaded()
        {
            throw new NotSupportedException();
        }

        ///<summary>
        /// 默认入口点
        ///</summary>
        public virtual void EntryPoint(params object[] args)
        {
            throw new NotSupportedException();
        }
    }
}