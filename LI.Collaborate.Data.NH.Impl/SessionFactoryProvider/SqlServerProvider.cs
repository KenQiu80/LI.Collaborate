using System;
using System.Web;
using System.Web.Configuration;
using System.Reflection;

using NHibernate;
using NHibernate.Cfg;

using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

using LI.Collaborate.Data.NH.Impl.Utils;
using LI.Collaborate.Mappings.Fluent.TypeConvention;

namespace LI.Collaborate.Data.NH.Impl.SessionFactoryProvider
{
    /// <summary>
    /// 代表了以NHibernate为核心的SqlServer的数据库访问类
    /// </summary>
    public class SqlServerProvider : Provider<SqlServerProvider>
    {

        #region Fields

        /// <summary>
        /// 全局唯一的NHibernate.ISessionFactory对象
        /// </summary>
        private static ISessionFactory _factory = null;

        /// <summary>
        /// Singleton模式中实现Double Check的对象
        /// </summary>
        private static readonly Object _mutex = new Object();

        #endregion

        #region Constructors

        /// <summary>
        /// 初始化一个LI.Collaborate.Data.NH.Impl.SessionFactoryProvider.SqlServerProvider对象，
        /// 该构造方法为私有方法，它主要被Singleton模式所使用。
        /// </summary>
        private SqlServerProvider()
        {

        }

        /// <summary>
        /// 初始化一个LI.Collaborate.Data.NH.Impl.SessionFactoryProvider.SqlServerProvider对象，
        /// 该构造方法为静态方法，它主要用来初始化Singleton模式中所必要的static readonly字段。
        /// </summary>
        static SqlServerProvider()
        {

        }

        #endregion

        /// <summary>
        /// 创建NHibernate.ISessionFactory实例
        /// </summary>
        /// <returns>由指定参数配置完毕的NHibernate.ISessionFactory对象</returns>
        public override ISessionFactory CreateFactory()
        {
            _factory = (ISessionFactory)HttpRuntime.Cache[key];

            if (_factory == null)
            {
                lock (_mutex)
                {
                    if (_factory == null)
                    {
                        _factory = BuildSessionFactory(buildSchema);
                        HttpRuntime.Cache.Insert(key, _factory);
                    }
                }
            }

            return SqlServerProvider._factory;
        }

        /// <summary>
        /// 创建全局唯一的ISessionFactory对象
        /// </summary>
        /// <param name="buildSchema">确定是否重建数据库， 该值为真，重建，否则，使用现有数据库</param>
        /// <returns>创建的全局唯一的ISessionFactory对象</returns>
        private ISessionFactory BuildSessionFactory(Boolean buildSchema)
        {
            Configuration config;

            if (WebConfigurationManager.AppSettings["XmlMapping"] == "false")
            {
                FluentConfiguration fluentConfig = Fluently.Configure()
                    .Database(MsSqlConfiguration.MsSql2008.ConnectionString(c => c.Server(server)
                        .Database(database)
                        .TrustedConnection())
                        .ShowSql())
                    .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.Load(mappingAssembly))
                    .Conventions.AddFromAssemblyOf<EnumConvention>())
                    .CurrentSessionContext<CurrentSessionContext>();
                    //.Cache(m => m.UseSecondLevelCache()
                    //    .ProviderClass<MemCacheProvider>()
                    //    .UseQueryCache()
                    //    .UseMinimalPuts());

                if (buildSchema)
                    fluentConfig.ExposeConfiguration(BuildSchema);

                config = fluentConfig.BuildConfiguration();
            }
            else
            {
                config = new Configuration().Configure();

                if (buildSchema)
                    BuildSchema(config);
            }

            SqlServerProvider._factory = config.BuildSessionFactory();

            return _factory;
        }
    }
}