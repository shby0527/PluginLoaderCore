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


    }
}