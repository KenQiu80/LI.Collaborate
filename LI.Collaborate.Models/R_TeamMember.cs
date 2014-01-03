using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LI.Collaborate.Models.Enum;

namespace LI.Collaborate.Models
{
    public class R_TeamMember
    {
        /// <summary>
        /// 获取或设置唯一标识事件与相关责任人的Id
        /// </summary>
        public String Id { get; set; }

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
