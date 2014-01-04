using System;
using System.Web;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NHibernate;
using NHibernate.Engine;
using NHibernate.Context;

using FluentNHibernate;

namespace LI.Collaborate.Data.NH.Impl.Utils
{
    /// <summary>
    /// 实现NHibernate的ICurrentSessionContext
    /// </summary>
    public class CurrentSessionContext : ICurrentSessionContext
    {
        #region Fields

        /// <summary>
        /// 代表当前使用中的NHibernate.ISessionFactoryImplementor对象，
        /// 该对象定义了与ISessionFactory交互的内部契约
        /// </summary>
        private readonly ISessionFactoryImplementor _factory;
        private const String CurrentSessionKey = "NHibernateCurrentSession";

        #endregion

        #region Constructors

        /// <summary>
        /// 初始化实例LI.Collaborate.Data.NH.Impl.Utils.CurrentSessionContext实例
        /// </summary>
        /// <param name="factory">代表当前使用中的NHibernate.ISessionFactoryImplementor对象，
        /// 该对象定义了与ISessionFactory交互的内部契约</param>
        public CurrentSessionContext(ISessionFactoryImplementor factory)
        {
            this._factory = factory;
        }

        #endregion

        #region Public methods

        /// <summary>
        /// 为每个请求绑定唯一的ISession对象。
        /// </summary>
        /// <param name="context">保存着当前请求信息的 System.Web.HttpContextBase对象</param>
        /// <param name="factory">全局唯一的 ISessionFactory 对象</param>
        /// <param name="session">请求中唯一的 ISession 对象</param>
        public static void Bind(ISession session)
        {
            HttpContext.Current.Items[CurrentSessionKey] = session;
        }

        /// <summary>
        /// 请求结束或异常发生，将 ISession 对象从请求中移除。
        /// </summary>
        /// <param name="context">当前请求</param>
        /// <param name="factory">全局唯一的 ISessionFactory 对象</param>
        /// <returns>将被移除并关闭的 ISession 对象</returns>
        public static ISession Unbind()
        {
            var session = HttpContext.Current.Items[CurrentSessionKey] as ISession;
            HttpContext.Current.Items[CurrentSessionKey] = null;

            if (session == null)
                throw new Exception("Session in request is null");

            return session;
        }

        #endregion

        #region ICurrentSessionContext members

        /// <summary>
        /// 获取当前有效的NHibernate.ISession对象
        /// </summary>
        /// <returns>当前有效的NHibernate.ISession对象</returns>
        public ISession CurrentSession()
        {
            var session = HttpContext.Current.Items[CurrentSessionKey] as ISession;

            if (session == null)
                return null;

            return session;
        }

        #endregion
    }
}