using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LI.Collaborate.Data.NH;
using LI.Collaborate.Data.NH.Impl.Utils;

using NHibernate;

namespace LI.Collaborate.Data.NH.Impl
{
    /// <summary>
    /// 作为使用NHibernate为核心的数据库查询语句基类，该类为抽象类
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    public abstract class NHibernateQueryBase<TResult>
        : TransactionWrapper, INHibernateQuery<TResult>
    {
        #region Constructors

        /// <summary>
        /// 初始化一个LI.Collaborate.Data.NH.Impl.NHiberanteQueryBase对象，该构造方法只能被子类调用
        /// </summary>
        protected NHibernateQueryBase()
        {

        }

        #endregion

        /// <summary>
        /// 执行数据填充完毕的SQL语句对象并返回结果
        /// </summary>
        /// <returns>SQL语句对象执行结果</returns>
        public abstract TResult Execute();
    }
}
