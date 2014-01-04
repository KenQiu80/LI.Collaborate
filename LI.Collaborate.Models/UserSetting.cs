using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LI.Common.Utils.Model;

namespace LI.Collaborate.Models
{
    public class UserSetting : Entity
    {
        #region Constructors

        /// <summary>
        /// 实例化一个<see cref="LI.Collaborate.Models.UserSetting"/>对象
        /// </summary>
        public UserSetting()
        {

        }

        #endregion

        #region Properities

        #region General setting

        /// <summary>
        /// 获取或设置界面主题
        /// </summary>
        public String Theme { get; set; }

        #endregion

        #region Reminder setting

        /// <summary>
        /// 获取或设置是否通过邮件发送事件提醒
        /// </summary>
        public Boolean RemindMeViaMail { get; set; }

        /// <summary>
        /// 获取或设置是否通过短信发送事件提醒
        /// </summary>
        public Boolean RemindMeViaSMS { get; set; }

        #endregion

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
