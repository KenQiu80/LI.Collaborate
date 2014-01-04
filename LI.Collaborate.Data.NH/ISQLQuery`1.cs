using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LI.Collaborate.Data.NH
{
    /// <summary>
    /// 提供了以SQL语句作为主要手段的数据库查询业务对象接口
    /// </summary>
    public interface ISQLQuery<T>
        : INHibernateQuery<T>
    {
    }
}
