using System;

using NHibernate;

namespace LI.Collaborate.Data.NH.Impl
{
    public abstract class PaginationQueryBase<T>
        : NHibernateQueryBase<PagedResult<T>>, IPaginationQuery<T>
    {

        #region Constructors

        /// <summary>
        /// 初始化一个泛型LI.Collaborate.Data.NH.Impl.PaginationQueryBase对象，该构造方法只能由子类调用
        /// </summary>
        protected PaginationQueryBase()
        {
            
        }

        /// <summary>
        /// 初始化一个泛型LI.Collaborate.Data.NH.Impl.PaginationQueryBase对象，该构造方法只能由子类调用
        /// </summary>
        /// <param name="pageIndex">页码，不小于1</param>
        /// <param name="pageSize">分页显示的内容条数</param>
        protected PaginationQueryBase(Int32 pageIndex, Int32 pageSize)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
        }

        #endregion

        #region Implementations of IPaginationQuery<T>

        /// <summary>
        /// 获取或设置页码，页码不小于1
        /// </summary>
        public Int32 PageIndex { get; set; }

        /// <summary>
        /// 获取或设置分页显示的内容条数
        /// </summary>
        public Int32 PageSize { get; set; }

        #endregion

        #region Implementation of NHibernateQueryBase<PagedResult<T>>


        /// <summary>
        /// 执行数据填充完毕的SQL语句对象并返回结果
        /// </summary>
        /// <returns>分页查询结果</returns>
        public override PagedResult<T> Execute()
        {
            var query = GetQuery();
            ProcessPagination(query);
            return RunTransaction(() => Execute(query));
        }

        #endregion

        #region Abstract Methods

        /// <summary>
        /// 获取查询所需的泛型IQuery对象
        /// </summary>
        /// <returns>一个填充了查询条件数据并代表可用于查询的SQL语句的泛型IQueryOver对象</returns>
        protected abstract IQueryOver<T, T> GetQuery();

        #endregion

        #region Non-Public Methods

        /// <summary>
        /// 根据页码和每页显示的最大内容条数来计算分页的起点位置
        /// </summary>
        /// <param name="query">根据当前页码计算出来的分页内容查询Query</param>
        protected virtual void ProcessPagination(IQueryOver<T, T> query)
        {
            var pageSize = PageSize;
            var skipCount = (PageIndex - 1)*pageSize;
            query.Skip(skipCount).Take(pageSize);
        }

        /// <summary>
        /// 执行数据填充完毕的SQL语句对象并返回结果
        /// </summary>
        /// <param name="query">一个填充了查询条件数据并代表可用于查询的SQL语句的泛型IQueryOver对象</param>
        /// <returns>代表分页查询结果的泛型LI.Collaborate.Data.NH.PagedResult对象</returns>
        protected virtual PagedResult<T> Execute(IQueryOver<T, T> query)
        {
            var totalPages = 0;
            var items = query.Future<T>();
            var count = query.ToRowCountQuery().FutureValue<Int32>();

            if ((count.Value % PageSize) > 0)
                totalPages++;
            else
                totalPages = count.Value/PageSize;

            return new PagedResult<T>(count.Value, totalPages, PageIndex, PageSize, items);
        }

        #endregion
    }
}