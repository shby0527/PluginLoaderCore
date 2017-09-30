using System;
using System.Collections.Generic;
using System.Text;

namespace PluginLoader.Exceptions
{
    /// <summary>
    /// 丢失插件信息异常
    /// </summary>
    public sealed class PluginInfoMissingException : SystemException
    {
        public PluginInfoMissingException()
            : base("Plugin information attribute was missing")
        {
        }

        public PluginInfoMissingException(string message)
            : base(message)
        {
        }
    }
}
