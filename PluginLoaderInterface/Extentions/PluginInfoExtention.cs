using System;
using System.Collections.Generic;
using System.Text;

using PluginLoader.Plugin.Common;
using PluginLoader.Attributes;
using PluginLoader.Exceptions;

namespace PluginLoader.Extentions
{
    public static class PluginInfoExtention
    {
        /// <summary>
        /// 获取插件版本
        /// </summary>
        /// <param name="plugin"></param>
        /// <returns></returns>
        public static Version GetPluginVersion(this IPlugin plugin)
        {
            return GetPluginAttribute(plugin).Version;
        }

        /// <summary>
        /// 获取插件名字
        /// </summary>
        /// <param name="plugin"></param>
        /// <returns></returns>
        public static string GetPluginName(this IPlugin plugin)
        {
            return GetPluginAttribute(plugin).PluginName;
        }

        /// <summary>
        /// 获取插件作者名字
        /// </summary>
        /// <param name="plugin"></param>
        /// <returns></returns>
        public static string GetPluginAuthorName(this IPlugin plugin)
        {
            return GetPluginAttribute(plugin).Author;
        }

        /// <summary>
        /// 获取插件特性类
        /// </summary>
        /// <param name="plugin"></param>
        /// <returns></returns>
        private static PluginAttribute GetPluginAttribute(IPlugin plugin)
        {
            Type type = plugin.GetType();
            object[] attrs = type.GetCustomAttributes(typeof(PluginAttribute), true);
            if (attrs == null || attrs.Length == 0)
                throw new PluginInfoMissingException();
            return (PluginAttribute)attrs[0];
        }
    }
}
