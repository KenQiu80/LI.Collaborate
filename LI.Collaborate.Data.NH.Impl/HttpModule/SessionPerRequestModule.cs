using System;
using System.IO;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NHibernate;

using LI.Collaborate.Data.NH.Impl.Utils;
using LI.Collaborate.Data.NH.Impl.SessionFactoryProvider;

namespace LI.Collaborate.Data.NH.Impl.HttpModule
{
    /// <summary>
    /// 该类提供了对NHibernate Session per Request 的支持。
    /// </summary>
    public class SessionPerRequestModule : IHttpModule
    {
        #region Fields

        private HttpApplication _httpApplication;

        #endregion

        #region Properties

        /// <summary>
        /// 设置或获取一个ISessionFactory对象实例，该实例使用Singleton模式构建。
        /// </summary>
        protected internal ISessionFactory Factory
        {
            get;
            private set;
        }

        #endregion

        #region Events

        protected internal void NH_OnBeginRequest(HttpContextBase context)
        {
            ISession session = BeginSession();
            CurrentSessionContext.Bind(session);
        }

        protected internal void NH_OnEndRequest(HttpContextBase context)
        {
            ISession session = CurrentSessionContext.Unbind();
            EndSession(session);
        }

        #endregion

        #region Private Method
        
        /// <summary>
        /// 请求开始时，创建新的ISession对象，并开启事务。
        /// </summary>
        /// <returns>创建每个请求中唯一的ISession对象</returns>
        private ISession BeginSession()
        {
            ISession session = Factory.OpenSession();
            session.BeginTransaction();

            return session;
        }

        /// <summary>
        /// Request successed or exception occured，close session after T-SQL statements submitted or rolled back.
        /// </summary>
        /// <param name="session">将被关闭的ISession对象</param>
        /// <param name="isRoolback">确定事务是否回滚，该值为真，回滚，否则，提交</param>
        private void EndSession(ISession session, Boolean isRoolback = false)
        {
            if (session == null)
                return;

            if (session.Transaction != null && session.Transaction.IsActive)
            {
                if (isRoolback)
                    session.Transaction.Rollback();
                else
                    session.Transaction.Commit();
            }
        }

        #endregion

        #region IHttpHandler members

        public void Init(HttpApplication context)
        {
            this._httpApplication = context;
            this.Factory = ProviderInitializer<SqlServerProvider>.Initialize.CreateFactory();

            context.BeginRequest += ((sender, e) => NH_OnBeginRequest(new HttpContextWrapper(((HttpApplication)sender).Context)));
            context.EndRequest += ((sender, e) => NH_OnEndRequest(new HttpContextWrapper(((HttpApplication)sender).Context)));
        }

        public void Dispose()
        {
            _httpApplication.BeginRequest -= ((sender, e) => NH_OnBeginRequest(new HttpContextWrapper(((HttpApplication)sender).Context)));
            _httpApplication.EndRequest -= ((sender, e) => NH_OnEndRequest(new HttpContextWrapper(((HttpApplication)sender).Context)));
        }

        #endregion
    }
}