using System;
using System.Collections.Generic;
using System.Text;



namespace PluginLoader.Attributes
{
    /// <summary>
    /// 约定一个默认的插件加载器
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
    public sealed class PluginFactoryAttribute : Attribute
    {
        /// <summary>
        /// 初始化若不提供程序集中的插件加载器，则使用默认
        /// </summary>
        /// <param name="factory"></param>
        public PluginFactoryAttribute(Type factory)
        {
            this.PluginFactory = factory;
        }

        /// <summary>
        /// 获取加载器
        /// </summary>
        public Type PluginFactory { get; }
    }
}
