using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LI.Common.Utils.Model;
using LI.Collaborate.Models.Enum;

namespace LI.Collaborate.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Event : Entity
    {
        #region Constructors

        /// <summary>
        /// 实例化一个<see cref="LI.Collaborate.Models.Event"/>对象
        /// </summary>
        public Event()
        {

        }

        #endregion

        #region Properities

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
        /// 获取或设置事件循环机制（每日、月度、季度或自定义）
        /// </summary>
        public EventRepeatOption Repeat { get; set; }

        /// <summary>
        /// 获取或设置是否启用事件提醒
        /// </summary>
        public Boolean EnableRemindMe { get; set; }

        /// <summary>
        /// 获取或设置事件提醒时间
        /// </summary>
        public DateTime RemindMeAt { get; set; }

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

        #endregion

        #region Members of LI.Common.Utils.Model.Entity

        /// <summary>
        /// 获取或设置唯一标识实体模型的Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 获取或设置事件创建人Id
        /// </summary>
        public string CreatorId { get; set; }

        /// <summary>
        /// 获取或设置事件创建人姓名
        /// </summary>
        public string CreatorName { get; set; }

        /// <summary>
        /// 获取或设置事件创建时间
        /// </summary>
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// 获取或设置事件最后修改人Id
        /// </summary>
        public string ModifierId { get; set; }

        /// <summary>
        /// 获取或设置事件最后修改人姓名
        /// </summary>
        public string ModifierName { get; set; }

        /// <summary>
        /// 获取或设置事件最后修改时间
        /// </summary>
        public DateTime ModifiedTime { get; set; }

        #endregion
    }
}
