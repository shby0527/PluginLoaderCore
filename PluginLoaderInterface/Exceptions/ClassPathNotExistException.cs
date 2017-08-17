using System;
using System.IO;

namespace PluginLoader.Exceptions
{
    ///<summary>没有找到所提供的加载路径</summary>
    public sealed class ClassPathNotExistException : IOException
    {
        public ClassPathNotExistException()
            : base("Class path was not found")
        {

        }

        public ClassPathNotExistException(string message)
            : base(message)
        {
            
        }
    }
}