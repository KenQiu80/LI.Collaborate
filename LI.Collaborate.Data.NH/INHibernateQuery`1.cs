using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LI.Collaborate.Data.NH
{
    /// <summary>
    /// 提供了代表NHibernate查询语句对象的基本接口
    /// </summary>
    /// <typeparam name="TResult">查询结果的数据集类型</typeparam>
    public interface INHibernateQuery<TResult> : INHibernateQuery
    {
        /// <summary>
        /// 执行数据填充完毕的SQL语句对象并返回结果
        /// </summary>
        /// <returns>SQL语句对象执行结果</returns>
        TResult Execute();
    }
}
