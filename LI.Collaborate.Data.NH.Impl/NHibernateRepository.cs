using System;
using System.Collections.Generic;

using LI.Collaborate.Data.NH;
using LI.Collaborate.Data.NH.Impl.Utils;

namespace LI.Collaborate.Data.NH.Impl
{
    /// <summary>
    /// 代表了实现Repository模式的数据库基本操作接口
    /// </summary>
    /// <typeparam name="T">集合中的业务实体类型</typeparam>
    //public class NHibernateRepository<T> : 
    //    TransactionWrapper, 
    //    IRepository<T>
    //{

    //    #region Fields

    //    /// <summary>
    //    /// 用于通过IoC模式创建LI.Collaborate.Data.NH.INHibernateQuery<T>实例的LI.Collaborate.Data.NH.IQueryFactory对象
    //    /// </summary>
    //    private readonly IQueryFactory queryFactory;

    //    #endregion

    //    #region Constructors

    //    /// <summary>
    //    /// 初始化一个实现数据库基本操作的NHibernateRepository对象
    //    /// </summary>
    //    public NHibernateRepository()
    //    {

    //    }

    //    /// <summary>
    //    /// 初始化一个实现数据库基本操作的NHibernateRepository对象
    //    /// </summary>
    //    /// <param name="queryFactory">用于通过IoC模式创建LI.Collaborate.Data.NH.INHibernateQuery<T>实例的LI.Collaborate.Data.NH.IQueryFactory对象</param>
    //    public NHibernateRepository(IQueryFactory queryFactory)
    //    {
    //        this.queryFactory = queryFactory;
    //    }

    //    #endregion

    //    #region Implementations of LI.Collaborate.Data.NH.IRepository<T>

    //    /// <summary>
    //    /// 创建业务对象
    //    /// </summary>
    //    /// <param name="item">待添加的业务对象</param>
    //    public void Create(T item)
    //    {
    //        RunTransaction(() => Session.Save(item));
    //    }

    //    /// <summary>
    //    /// 修改指定的业务对象
    //    /// </summary>
    //    /// <param name="item">待修改的业务对象</param>
    //    public void Modify(T item)
    //    {
    //        RunTransaction(() => Session.Update(item));
    //    }

    //    /// <summary>
    //    /// 删除指定的业务对象
    //    /// </summary>
    //    /// <param name="item">待删除的业务对象</param>
    //    /// <returns>删除成功，返回true，否则，返回false</returns>
    //    public Boolean Remove(T item)
    //    {
    //        RunTransaction(() => Session.Delete(item));
    //        return true;
    //    }

    //    /// <summary>
    //    /// 查询数据集中是否包含某个具体的业务对象数据
    //    /// </summary>
    //    /// <param name="item">待查询的业务对象</param>
    //    /// <returns>集合中包含业务对象，返回true，否则，返回false</returns>
    //    public Boolean Contains(T item)
    //    {
    //        if (item.Id == default(Guid))
    //            return false;

    //        return RunTransaction(() => Session.Get<T>(item.Id)) != null;
    //    }

    //    /// <summary>
    //    /// 获取数据集中的数据数量
    //    /// </summary>
    //    //public Int32 Count
    //    //{
    //    //    get
    //    //    {
    //    //        return RunTransaction(() => Session.QueryOver<T>().RowCount());
    //    //    }
    //    //}

    //    #endregion

    //    #region Implementations of System.Collections.Generic.IEnumerable<out T>
        
    //    public IEnumerator<T> GetEnumerator()
    //    {
    //        //return RunTransaction(() => session.Query<T>().Take(1000).GetEnumerator();
    //        return null;
    //    }

    //    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    //    {
    //        return RunTransaction(() => GetEnumerator());
    //    }

    //    #endregion

    //    #region Implementations of LI.Collaborate.Data.NH.IQueryFactory

    //    /// <summary>
    //    /// 创建LI.Collaborate.Data.NH.INHibernateQuery对象，该方法通过IoC模式有效降低了耦合度
    //    /// </summary>
    //    /// <typeparam name="TQuery">LI.Collaborate.Data.NH.INHibernateQuery对象</typeparam>
    //    /// <returns>一个尚未填充数据的LI.Collaborate.Data.NH.INHibernateQuery对象</returns>
    //    public TQuery CreateQuery<TQuery>() where TQuery : NH.INHibernateQuery
    //    {
    //        return queryFactory.CreateQuery<TQuery>();
    //    }

    //    #endregion
    //}
}