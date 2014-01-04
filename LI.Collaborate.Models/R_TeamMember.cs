using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LI.Collaborate.Models.Enum;
using LI.Common.Utils.Model;

namespace LI.Collaborate.Models
{
    public class R_TeamMember : Entity
    {
        #region Constructors

        /// <summary>
        /// 实例化一个<see cref="LI.Collaborate.Models.R_TeamMember"/>对象
        /// </summary>
        public R_TeamMember()
        {

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
        /// 获取或设置参与事件相关责任人Id
        /// </summary>
        public String UserId { get; set; }

        /// <summary>
        /// 获取或设置事件相关责任人姓名
        /// </summary>
        public String UserName { get; set; }

        /// <summary>
        /// 获取或设置团队成员角色
        /// </summary>
        public TeamMemberRole Role { get; set; }

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
