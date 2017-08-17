using System;

namespace PluginLoader.Exceptions
{
    ///<summary>类没有验证通过</summary>
    public sealed class ClassVerifiationException : SystemException
    {
        public ClassVerifiationException()
            : base("Class Information Verifiation Fail")
        {

        }

        public ClassVerifiationException(string message)
            : base(message)
        {

        }
    }
}