using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LI.Collaborate.Models.Enum;

namespace LI.Collaborate.Models
{
    public class EventLink
    {
        /// <summary>
        /// 获取或设置唯一标识事件关联的Id
        /// </summary>
        public String Id { get; set; }

        /// <summary>
        /// 获取或设置即将关联的事件Id
        /// </summary>
        public String EventId1 { get; set; }

        /// <summary>
        /// 获取或设置即将关联的事件标题
        /// </summary>
        public String EventTitle1 { get; set; }

        /// <summary>
        /// 获取或设置即将关联的事件Id
        /// </summary>
        public String EventId2 { get; set; }

        /// <summary>
        /// 获取或设置即将关联的事件标题
        /// </summary>
        public String EventTitle2 { get; set; }

        /// <summary>
        /// 获取或设置事件之间的关联类型
        /// </summary>
        public EventRelationType Type { get; set; }

        /// <summary>
        /// 获取或设置事件创建人Id
        /// </summary>
        public String CreatorId { get; set; }

        /// <summary>
        /// 获取或设置事件创建人姓名
        /// </summary>
        public String CreatorName { get; set; }

        /// <summary>
        /// 获取或设置事件创建时间
        /// </summary>
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// 获取或设置事件最后修改人Id
        /// </summary>
        public String ModifierId { get; set; }

        /// <summary>
        /// 获取或设置事件最后修改人姓名
        /// </summary>
        public String ModifierName { get; set; }

        /// <summary>
        /// 获取或设置事件最后修改时间
        /// </summary>
        public DateTime ModifiedTime { get; set; }
    }
}
