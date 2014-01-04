using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NHibernate;

namespace LI.Collaborate.Data.NH.Impl.SessionFactoryProvider
{
    /// <summary>
    /// 代表了使用Singleton模式初始化数据库访问适配器对象的操作类
    /// </summary>
    /// <typeparam name="T">代表数据库访问适配器的
    /// LI.Collaborate.Data.NH.Impl.SessionFactoryProvider类型</typeparam>
    public class ProviderInitializer<T> where T : Provider<T>
    {
        #region Fields
        
        /// <summary>
        /// 全局唯一的数据库访问适配器实例对象
        /// </summary>
        private static T _provider;

        /// <summary>
        /// Singleton模式中实现Double Check的对象
        /// </summary>
        private static readonly Object _mutex;
        
        #endregion

        #region Constructors

        /// <summary>
        /// 初始化一个LI.Collaborate.Data.NH.Impl.SessionFactoryProvider.ProviderInitializer对象，
        /// 该构造方法为静态方法，它主要用来初始化Singleton模式中所必要的static readonly字段。
        /// </summary>
        static ProviderInitializer()
        {
            _mutex = new Object();
        }

        #endregion

        /// <summary>
        /// 根据指定的类型参数来初始化数据库访问适配器
        /// </summary>
        public static T Initialize
        {
            get
            {
                if (_provider == null)
                {
                    lock (_mutex)
                    {
                        if (_provider == null)
                        {
                            _provider = (T)Activator.CreateInstance(typeof(T), true);
                        }
                    }
                }

                return _provider;
            }
        }
    }
}
