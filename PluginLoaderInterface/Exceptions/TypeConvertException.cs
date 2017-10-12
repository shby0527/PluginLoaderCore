using System;
using System.Collections.Generic;
using System.Text;

namespace PluginLoader.Exceptions
{
    public sealed class TypeConvertException : SystemException
    {
        public TypeConvertException()
            : base("can not convert to the given type")
        {

        }

        public TypeConvertException(string message)
            : base(message)
        {

        }
    }
}
