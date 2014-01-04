using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LI.Collaborate.Data.NH
{
    /// <summary>
    /// 提供了可以将数据库查询结果进行分页显示的业务对象接口
    /// </summary>
    public class PagedResult<T>
    {
        #region Fields

        private Int32 totalItems;
        private Int32 totalPages;
        private Int32 pageIndex;
        private Int32 pageSize;

        #endregion

        #region Constructors

        /// <summary>
        /// 初始化一个泛型LI.Collaborate.Data.NH.PagedResult对象，该构造方法只能由子类调用
        /// </summary>
        public PagedResult()
        {
            
        }

        /// <summary>
        /// 初始化一个泛型LI.Collaborate.Data.NH.PagedResult对象，该构造方法只能由子类调用
        /// </summary>
        /// <param name="totalItems">所有信息条数</param>
        /// <param name="totalPages">所有页数</param>
        /// <param name="pageIndex">不小于1的页码</param>
        /// <param name="pageSize">分页显示的内容条数</param>
        /// <param name="results">保存分页数据集的泛型IEnumerable对象</param>
        public PagedResult(Int32 totalItems, Int32 totalPages, Int32 pageIndex, Int32 pageSize, IEnumerable<T> results)
        {
            TotalItems = totalItems;
            TotalPages = totalPages;
            PageIndex = pageIndex;
            PageSize = pageSize;
            Results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// 获取或设置所有信息条数
        /// </summary>
        public Int32 TotalItems
        {
            get { return totalItems; }
            set { totalItems = value; }
        }

        /// <summary>
        /// 获取或设置所有页数
        /// </summary>
        public Int32 TotalPages { get; set; }

        /// <summary>
        /// 获取或设置页码，页码不小于1
        /// </summary>
        public Int32 PageIndex { get; set; }

        /// <summary>
        /// 获取或设置分页显示的内容条数
        /// </summary>
        public Int32 PageSize { get; set; }

        /// <summary>
        /// 获取或设置保存分页数据集的泛型IEnumerable对象
        /// </summary>
        public IEnumerable<T> Results { get; set; }

        #endregion
    }
}
