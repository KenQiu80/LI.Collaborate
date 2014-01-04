using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LI.Collaborate.Data.NH.Impl
{
    /// <summary>
    /// 作为以NamedQuery为主要手段的数据库查询业务对象基类，该类为抽象类
    /// </summary>
    /// <typeparam name="TResult">查询结果的数据集类型</typeparam>
    public abstract class NamedQueryBase<TResult>
        : NHibernateQueryBase<TResult>, INamedQuery<TResult>
    {
        
        #region Constructors

        /// <summary>
        /// 初始化一个LI.Collaborate.Data.NH.Impl.NamedQueryBase对象，该构造方法只能由子类调用
        /// </summary>
        protected NamedQueryBase()
        {
            
        }

        #endregion

        #region Implementation of NHibernateQueryBase<TResult>

        /// <summary>
        /// 执行数据填充完毕的SQL语句对象并返回结果
        /// </summary>
        /// <returns>SQL语句对象执行结果</returns>
        public override TResult Execute()
        {
            var query = GetQuery();
            return RunTransaction<TResult>(() => Execute(query));
        }

        #endregion

        #region Abstract Methods

        /// <summary>
        /// 获取查询所需的NamedQuery字符串
        /// </summary>
        /// <returns>一个填充了查询条件数据并代表可用于查询的SQL语句的HQL字符串</returns>
        public abstract String GetQuery();

        /// <summary>
        /// 执行数据填充完毕的SQL语句对象并返回结果
        /// </summary>
        /// <param name="query">完成查询条件组装并赋值的SQL语句对象</param>
        /// <returns>SQL语句对象执行结果</returns>
        public abstract TResult Execute(String query); 

        #endregion
    }
}
