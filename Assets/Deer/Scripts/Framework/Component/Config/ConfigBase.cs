// ================================================
//描 述 :  
//作 者 : 杜鑫 
//创建时间 : 2021-07-09 08-18-03  
//修改作者 : 杜鑫 
//修改时间 : 2021-07-09 08-18-03  
//版 本 : 0.1 
// ===============================================

using System;
using System.Collections;
using System.IO;
using System.Reflection;
using GameFramework;
namespace Deer
{
    [Config]
    public abstract class ConfigBase<T> : IConfig where T : class, new()
    {
        private static T m_Instance;
        
        public ConfigBase()
        {
            m_Instance = this as T;
        }
        /// <summary>
        /// 单例
        /// </summary>
        /// <returns></returns>
        public static T Instance
        {
            get 
            {
                if (m_Instance == null)
                {
                    m_Instance = new T();
                }
                return m_Instance;
            }
        }

        public abstract string Name
        {
            get;
        }

        /// <summary>
        /// 加载配置表数据
        /// </summary>
        /// <returns></returns>
        public abstract IEnumerator LoadConfig(bool isReadWritePath);

        public abstract void Clear();

        /// <summary>
        /// 解析配置表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="csvName"></param>
        /// <returns></returns>
        protected U AnalyseConfig<U>(string excelName,string rootPath) 
        {
            U config = default(U);
            string path = Path.Combine(rootPath, Utility.Text.Format("Config/{0}.bin", excelName));
            if (!File.Exists(path))
            {
                Log.Error("filepath:" + path + " not exists");
                return config;
            }

            byte[] content = File.ReadAllBytes(path);
        
            //反序列化
            config = Deserialize<U>(content, excelName);

            return config;
        }
        protected void AnalyseConfig<U>(string excelName, bool isReadWritePath, Action<U> action)
        {
            U config = default(U);
            FileUtils.FileReadAllBytes(Utility.Text.Format("Config/{0}.bin", excelName), isReadWritePath, delegate (bool isRead,byte[] result) {
                //反序列化
                config = Deserialize<U>(result, excelName);
                action?.Invoke(config);
            });
        }

        public U Deserialize<U>(byte[] content, string excelName)
        {
            U excelConfig = default(U);
            if (content.Length > 0)
            {
                try
                {
                    FieldInfo parserField = typeof(U).GetField("_parser", BindingFlags.Static | BindingFlags.NonPublic);
                    if (parserField != null)
                    {
                        object objParser = parserField.GetValue(null);
                        MethodInfo method = parserField.FieldType.GetMethod("ParseFrom", new Type[] { typeof(byte[])});
                        if (method != null) excelConfig = (U) method.Invoke(objParser, new object[] {content});
                    }
                }
                catch (Exception ex)
                {
                    Log.Error(excelName + " excel config deserialization error：" + ex.Message);
                }
            }
            return excelConfig;
        }
    }
}