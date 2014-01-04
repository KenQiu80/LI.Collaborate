using System;
using System.Web;
using System.Web.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace LI.Collaborate.Data.NH.Impl.SessionFactoryProvider
{
    /// <summary>
    /// 作为实现以NHibernate为核心的指定数据库访问适配器的抽象基类，
    /// 该类包含了读取配置的属性和生成NHibernate.ISessionFactory对象的方法
    /// </summary>
    /// <typeparam name="T">代表数据库访问适配器的
    /// LI.Collaborate.Data.NH.Impl.SessionFactoryProvider.Provider类型</typeparam>
    public abstract class Provider<T>
        where T : Provider<T>
    {
        #region Fields

        /// <summary>
        /// 存储在缓存中标识唯一ISessionFactory的键
        /// </summary>
        protected String key;

        /// <summary>
        /// 数据库服务器地址
        /// </summary>
        protected String server;

        /// <summary>
        /// 数据库名称
        /// </summary>
        protected String database;

        /// <summary>
        /// 含有映射关系的Assembly名称
        /// </summary>
        protected String mappingAssembly;

        /// <summary>
        /// 标识是否重建数据库
        /// </summary>
        protected Boolean buildSchema;

        #endregion

        #region Constructors

        /// <summary>
        /// 初始化一个LI.Collaborate.Data.NH.Impl.SessionFactoryProvider.Provider实例
        /// </summary>
        protected Provider()
        {
            key = typeof(T).ToString();
            server = WebConfigurationManager.AppSettings["Server"];
            database = WebConfigurationManager.AppSettings["Database"];
            mappingAssembly = WebConfigurationManager.AppSettings["MappingAssembly"];
            buildSchema = Boolean.Parse(WebConfigurationManager.AppSettings["BuildSchema"]);
        }

        #endregion

        /// <summary>
        /// 创建NHibernate.ISessionFactory实例
        /// </summary>
        /// <returns>由指定参数配置完毕的NHibernate.ISessionFactory对象</returns>
        public abstract ISessionFactory CreateFactory();

        /// <summary>
        /// 根据映射关系创建数据库
        /// </summary>
        /// <param name="config">创建数据库所需的配置对象</param>
        protected void BuildSchema(Configuration config)
        {
            var schema = new SchemaExport(config);
            schema.Execute(true, true, false);
        }
    }
}