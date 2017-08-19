using System;

namespace PluginLoader.Attributes
{

    ///<summary>
    ///标记到程序集，用来指定用来创建该程序集中插件的工厂类
    ///</summary>
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
    public sealed class LoaderFactoryAttribute : Attribute
    {
        private Type _type;

        public Type FactoryClass
        {
            get
            {
                return _type;
            }
        }

        public LoaderFactoryAttribute(Type factoryClass)
        {
            this._type = factoryClass;
        }
    }
}