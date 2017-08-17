using System;

namespace PluginLoader.Exceptions
{
    ///<summary>类格式错误，不符合加载要求的类</summary>
    public sealed class ClassFormatException : SystemException
    {
        public ClassFormatException()
            : base("the Class was not normally")
        {
            
        }

        public ClassFormatException(string message)
            : base(message)
        {

        }
    }
}