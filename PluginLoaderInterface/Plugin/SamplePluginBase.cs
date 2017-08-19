using System;

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

        public virtual bool Loading()
        {
            return true;
        }

        public virtual void Loaded()
        {

        }

        ///<summary>
        /// 默认入口点
        ///</summary>
        public virtual void EntryPoint(params object[] args)
        {

        }
    }
}