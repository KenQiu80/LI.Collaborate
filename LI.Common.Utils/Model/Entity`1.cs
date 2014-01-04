using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LI.Common.Utils.Model
{
    public interface Entity<T>
    {
        /// <summary>
        /// 获取或设置唯一标识实体模型的Id
        /// </summary>
        T Id { get; set; }
        
        /// <summary>
        /// 获取或设置事件创建人Id
        /// </summary>
        String CreatorId { get; set; }

        /// <summary>
        /// 获取或设置事件创建人姓名
        /// </summary>
        String CreatorName { get; set; }

        /// <summary>
        /// 获取或设置事件创建时间
        /// </summary>
        DateTime CreatedTime { get; set; }

        /// <summary>
        /// 获取或设置事件最后修改人Id
        /// </summary>
        String ModifierId { get; set; }

        /// <summary>
        /// 获取或设置事件最后修改人姓名
        /// </summary>
        String ModifierName { get; set; }

        /// <summary>
        /// 获取或设置事件最后修改时间
        /// </summary>
        DateTime ModifiedTime { get; set; }
    }
}
