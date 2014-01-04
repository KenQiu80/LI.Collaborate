using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LI.Collaborate.Models.Enum;
using LI.Common.Utils.Model;

namespace LI.Collaborate.Models
{
    public class EventLink : Entity
    {
        #region Constructors

        /// <summary>
        /// 实例化一个<see cref="LI.Collaborate.Models.EventLink"/>对象
        /// </summary>
        public EventLink()
        {

        }

        #endregion

        #region Properities

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
