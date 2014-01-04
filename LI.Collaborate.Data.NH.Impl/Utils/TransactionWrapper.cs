using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NHibernate;

using LI.Collaborate.Data.NH.Impl.SessionFactoryProvider;
using System.Web;

namespace LI.Collaborate.Data.NH.Impl.Utils
{
    /// <summary>
    /// 代表了对NHibernate事务进行封装的对象，所有数据库操作均需通过该类处理并最终执行。
    /// </summary>
    public class TransactionWrapper
    {
        #region Fields

        /// <summary>
        /// 获取或设置请求中的Session对象
        /// </summary>
        protected ISession Session { get; set; }

        #endregion

        #region Constructors

        public TransactionWrapper()
        {
        }

        #endregion

        #region Non-Public Methods

        /// <summary>
        /// 提交事务
        /// </summary>
        /// <typeparam name="TResult">匿名方法返回值</typeparam>
        /// <param name="func">带有返回值但没有参数的匿名方法</param>
        /// <returns>数据库操作执行完毕后的返回类型</returns>
        protected TResult RunTransaction<TResult>(Func<TResult> func)
        {
            if (this.Session == null)
                this.Session = (ISession)HttpContext.Current
                    .Items[ProviderInitializer<SqlServerProvider>.Initialize.CreateFactory()];

            TResult result;

            //判断事务是否被关闭,如果已经关闭则重新开启事务。该判断主要用于非Session Per Request模式
            if (!this.Session.Transaction.IsActive)
            {
                using (ITransaction trans = this.Session.BeginTransaction())
                {
                    result = func.Invoke();
                    trans.Commit();
                }
            }
            else
            {
                result = func.Invoke();
            }

            return result;
        }

        /// <summary>
        /// 提交事务
        /// </summary>
        /// <param name="action">没有返回值和参数的匿名方法</param>
        protected void RunTransaction(Action action)
        {
            RunTransaction<Boolean>(() =>
            {
                action.Invoke();
                return false;
            });
        }

        #endregion
    }
}
