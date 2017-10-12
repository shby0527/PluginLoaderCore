using System;
using System.Collections.Generic;
using System.Text;

using PluginLoader.Plugin.Common;

namespace PluginLoader.Util
{
    public static class PluginUtil
    {
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
    }
}
