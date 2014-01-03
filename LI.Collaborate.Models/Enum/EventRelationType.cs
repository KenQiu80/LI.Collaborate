using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LI.Collaborate.Models.Enum
{
    public enum EventRelationType
    {
        /// <summary>
        /// 代表了事件关联的父事件
        /// </summary>
        Parent = 1,

        /// <summary>
        /// 代表了事件关联的子事件
        /// </summary>
        Child = 2,

        /// <summary>
        /// 代表了事件关联的前置事件
        /// </summary>
        Predecessor = 3,

        /// <summary>
        /// 代表了事件关联的后置事件
        /// </summary>
        Successor = 4,

        /// <summary>
        /// 代表了事件关联存在某种其他关联
        /// </summary>
        Link = 5
    }
}
