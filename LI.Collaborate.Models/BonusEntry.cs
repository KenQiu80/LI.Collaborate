using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LI.Common.Utils.Model;

namespace LI.Collaborate.Models
{
    public class BonusEntry : Entity
    {
        #region Constructors

        /// <summary>
        /// 实例化一个<see cref="LI.Collaborate.Models.BonusEntry"/>对象
        /// </summary>
        public BonusEntry()
        {

        }

        /// <summary>
        /// 实例化一个<see cref="LI.Collaborate.Models.BonusEntry"/>对象
        /// </summary>
        /// <param name="eventId">事件Id</param>
        /// <param name="eventTitle">事件标题</param>
        public BonusEntry(String eventId, String eventTitle)
        {
            this.EventId = eventId;
            this.EventTitle = eventTitle;
        }

        #endregion

        #region Properities

        /// <summary>
        /// 获取或设置事件Id
        /// </summary>
        public String EventId { get; set; }

        /// <summary>
        /// 获取或设置事件标题
        /// </summary>
        public String EventTitle { get; set; }

        /// <summary>
        /// 获取或设置积分表单类型
        /// </summary>
        public Int32 Type { get; set; }

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
        /// 获取或设置积分表单备注
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
