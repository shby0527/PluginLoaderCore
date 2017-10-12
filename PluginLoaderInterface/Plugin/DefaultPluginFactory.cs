﻿using System;
using System.Reflection;

using PluginLoader.Plugin.Common;
using PluginLoader.Exceptions;
using PluginLoader.Util;

namespace PluginLoader.Plugin
{
    /// <summary>
    /// 默认创建器
    /// </summary>
    public class DefaultPluginFactory : IPluginFactory
    {
        /// <summary>
        /// 默认方法创建插件（使用无参构造方法）
        /// </summary>
        /// <param name="plugin"></param>
        /// <returns></returns>
        public virtual IPlugin CreateInstance(Type plugin)
        {
            if (plugin.IsAbstract)
                throw new ClassFormatException("abstract class can not create instance");
            if (!PluginUtil.CheckImplement(plugin))
                throw new ClassFormatException("not implement IPlugin interface");
            object ins = Activator.CreateInstance(plugin);
            return ins as IPlugin;
        }

        public virtual T CreateInstance<T>(Type plugin)
            where T : class, IPlugin
        {
            IPlugin ins = CreateInstance(plugin);

            if (!(ins is T))
                throw new TypeConvertException();
            return ins as T;
        }
    }
}
