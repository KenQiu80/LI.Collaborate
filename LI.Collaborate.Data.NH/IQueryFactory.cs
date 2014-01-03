using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LI.Collaborate.Data.NH
{
    /// <summary>
    /// 提供了通过IoC方式创建LI.Collaborate.Data.NH.INHibernateQuery接口实例的接口
    /// </summary>
    public interface IQueryFactory
    {
        /// <summary>
        /// 创建LI.Collaborate.Data.NH.INHibernateQuery对象，该方法通过IoC模式有效降低了耦合度
        /// </summary>
        /// <typeparam name="TQuery">LI.Collaborate.Data.NH.INHibernateQuery对象</typeparam>
        /// <returns>一个尚未填充数据的LI.Collaborate.Data.NH.INHibernateQuery对象</returns>
        TQuery CreateQuery<TQuery>() where TQuery : INHibernateQuery;
    }
}
