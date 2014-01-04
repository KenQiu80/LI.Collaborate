﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LI.Collaborate.Data.NH
{
    /// <summary>
    /// 提供了实现Repository模式的数据库基本操作接口
    /// </summary>
    /// <typeparam name="T">集合中的业务实体类型</typeparam>
    public interface IRepository<T> : IEnumerable<T>, IQueryFactory
    {
        /// <summary>
        /// 创建业务对象
        /// </summary>
        /// <param name="item">待添加的业务对象</param>
        void Create(T item);

        /// <summary>
        /// 修改指定的业务对象
        /// </summary>
        /// <param name="item">待修改的业务对象</param>
        void Modify(T item);

        /// <summary>
        /// 删除指定的业务对象
        /// </summary>
        /// <param name="item">待删除的业务对象</param>
        /// <returns>删除成功，返回true，否则，返回false</returns>
        bool Remove(T item);

        /// <summary>                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
        /// 查询数据集中是否包含某个具体的业务对象数据
        /// </summary>
        /// <param name="item">待查询的业务对象</param>
        /// <returns>集合中包含业务对象，返回true，否则，返回false</returns>
        bool Contains(T item);

        /// <summary>
        /// 获取数据集中的数据数量
        /// </summary>
        int Count { get; }
    }
}