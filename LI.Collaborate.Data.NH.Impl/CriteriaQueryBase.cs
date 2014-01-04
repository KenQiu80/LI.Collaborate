using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LI.Collaborate.Data.NH;

using NHibernate;

namespace LI.Collaborate.Data.NH.Impl
{
    /// <summary>
    /// 作为以NHibernate.ICriteria为主要手段的数据库查询业务对象基类，该类为抽象类
    /// </summary>
    /// <typeparam name="TResult">查询结果的数据集类型</typeparam>
    public abstract class CriteriaQueryBase<TResult> 
        : NHibernateQueryBase<TResult>, ICriteriaQuery<TResult>
    {
        #region Constructors

        /// <summary>
        /// 初始化一个LI.Collaborate.Data.NH.Impl.CriteriaQueryBase对象，该构造方法只能由子类调用
        /// </summary>
        protected CriteriaQueryBase()
        {
            
        }

        #endregion

        #region Implementation of NHibernateQueryBase<PagedResult<T>>

        /// <summary>
        /// 执行数据填充完毕的SQL语句对象并返回结果
        /// </summary>
        /// <returns>SQL语句对象执行结果</returns>
        public override TResult Execute()
        {
            var query = GetQuery();
            return RunTransaction(() => Execute(query));
        }

        #endregion

        #region Abstract Methods

        /// <summary>
        /// 获取查询所需的泛型IQueryOver对象
        /// </summary>
        /// <returns>一个填充了查询条件数据并代表可用于查询的SQL语句的泛型IQueryOver对象</returns>
        protected abstract IQueryOver<TResult, TResult> GetQuery();

        /// <summary>
        /// 执行数据填充完毕的SQL语句对象并返回结果
        /// </summary>
        /// <param name="query">完成查询条件组装并赋值的SQL语句对象</param>
        /// <returns>SQL语句对象执行结果</returns>
        protected abstract TResult Execute(IQueryOver<TResult, TResult> query);

        #endregion
    }
}