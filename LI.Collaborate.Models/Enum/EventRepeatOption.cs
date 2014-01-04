using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LI.Collaborate.Models.Enum
{
    public enum EventRepeatOption
    {
        /// <summary>
        /// 代表了每日实施的事件
        /// </summary>
        Daily = 1,

        /// <summary>
        /// 代表了每月实施的事件
        /// </summary>
        Monthly = 2,

        /// <summary>
        /// 代表了每季度实施的事件
        /// </summary>
        Quarterly = 3,

        /// <summary>
        /// 代表了自定义时间实施的事件
        /// </summary>
        Default = 4
    }
}
