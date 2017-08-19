using System;


namespace PluginLoader.Attributes
{

    /// <summary>
    /// 验证特性,用来验证该程序集合法性
    ///</summary>
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
    public sealed class SecretAttribute : Attribute
    {
        public SecretAttribute(string rsa, string sha512, string rsasha512)
        {
            this.RSA = rsa;
            this.SHA512 = sha512;
            this.RSASHA512 = rsasha512;
            this.IsDisableVail = false;
        }

        ///<summary>
        /// RSA 私钥加密后的内容(BASE64)
        ///</summary>
        public string RSA { get; set; }

        ///<summary>
        /// 对文件的SHA512
        ///</summary>
        public string SHA512 { get; set; }

        ///<summary>
        /// 对RSA的SHA512
        ///</summary>
        public string RSASHA512 { get; set; }

        ///<summary>
        /// Secret文件的文件名，该文件必须和程序集在同一个位子
        ///</summary>
        public string SecretFile { get; set; }

        ///<summary>
        /// 标注是否忽略验证,默认false,不建议设置
        ///</summary>
        public bool IsDisableVail{get;set;}
    }
}