using System;

namespace PluginLoader.Attributes
{
    /// <summary>
    /// 插件需要的特性类
    /// </summary>
    public sealed class PluginAttribute : Attribute
    {

        private string _name;
        private string _author;
        private Version _version;

        ///<summary>
        /// version格式 major.minor.build.revision
        ///</summary>
        public PluginAttribute(string name, string author, string version)
        {
            this._name = name;
            this._author = author;
            string[] ver = version.Split('.');
            int[] iver = new int[4];
            for (int i = 0; i < ver.Length && i < 4; i++)
            {
                iver[i] = Convert.ToInt32(ver[i]);
            }
            this._version = new Version(iver[0], iver[1], iver[2], iver[3]);
        }

        ///<summary>
        /// 是否需要懒加载
        /// 即 是否 在载入插件后立即实例化
        /// 如果为true，则在程序生命期内该插件始终保留同一个实例
        /// 若为false，则每次需要时实例化插件，每次使用为不同的实例
        ///</summary>
        public bool IsLazyLoading { get; set; }

        ///<summary>
        /// 插件名
        ///</summary>
        public string PluginName
        {
            get
            {
                return _name;
            }
        }

        ///<summary>
        /// 插件版本
        ///</summary>
        public Version Version
        {
            get
            {
                return this._version;
            }
        }

        ///<summary>
        /// 插件作者
        ///</summary>
        public string Author
        {
            get
            {
                return this._author;
            }
        }
    }
}