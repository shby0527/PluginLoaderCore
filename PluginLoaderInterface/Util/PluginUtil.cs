using System;
using System.Collections.Generic;
using System.Text;

using PluginLoader.Plugin.Common;
using PluginLoader.Attributes;
using PluginLoader.Exceptions;

namespace PluginLoader.Util
{
    public static class PluginUtil
    {
        /// <summary>
        /// 检查接口实现
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool CheckImplement(Type type)
        {
            Type[] implementeds = type.GetInterfaces();
            foreach (Type i in implementeds)
            {
                if (i == typeof(IPlugin))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 获取插件特性类
        /// </summary>
        /// <param name="plugin"></param>
        /// <returns></returns>
        public static PluginAttribute GetPluginAttribute(Type plugin)
        {
            Type type = plugin;
            object[] attrs = type.GetCustomAttributes(typeof(PluginAttribute), true);
            if (attrs == null || attrs.Length == 0)
                throw new PluginInfoMissingException();
            return (PluginAttribute)attrs[0];
        }
    }
}
