using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LI.Collaborate.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Event
    {
        /// <summary>
        /// 获取或设置唯一标识事件的Id
        /// </summary>
        public String Id { get; set; }

        /// <summary>
        /// 获取或设置负责事件的团队组长Id
        /// </summary>
        public String TeamLeaderId { get; set; }

        /// <summary>
        /// 获取或设置负责事件的团队组长姓名
        /// </summary>
        public String TeamLeaderName { get; set; }

        /// <summary>
        /// 获取或设置事件标题
        /// </summary>
        public String Title { get; set; }

        /// <summary>
        /// 获取或设置事件的开始时间
        /// </summary>
        public DateTime StartAt { get; set; }

        /// <summary>
        /// 获取或设置事件的结束时间
        /// </summary>
        public DateTime FinishAt { get; set; }

        /// <summary>
        /// 获取或设置完成事件所能够获得的积分，该值不能小于0
        /// </summary>
        public Decimal Bonus1 { get; set; }

        /// <summary>
        /// 获取或设置完成事件所能够获得的积分，该值不能小于0
        /// </summary>
        public Decimal Bonus2 { get; set; }

        /// <summary>
        /// 获取或设置完成事件所能够获得的积分，该值不能小于0
        /// </summary>
        public Decimal Bonus3 { get; set; }

        /// <summary>
        /// 获取或设置完成事件所能够获得的积分，该值不能小于0
        /// </summary>
        public Decimal Bonus4 { get; set; }

        /// <summary>
        /// 获取或设置完成事件所能够获得的积分，该值不能小于0
        /// </summary>
        public Decimal Bonus5 { get; set; }

        /// <summary>
        /// 获取或设置事件备注
        /// </summary>
        public String Remark { get; set; }

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
