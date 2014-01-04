using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LI.Collaborate.Data.NH
{
    /// <summary>
    /// 提供了以NHibernate.ICriteria作为主要手段的数据库查询业务对象接口
    /// </summary>
    public interface ICriteriaQuery<T>
        :INHibernateQuery<T>
    {
    }
}
