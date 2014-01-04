using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LI.Common.Utils.Model;

namespace LI.Collaborate.Models
{
    public class Attachment
    {
        
        #region Constructors

        /// <summary>
        /// 实例化一个<see cref="LI.Collaborate.Models.Attachment"/>对象
        /// </summary>
        public Attachment()
        {

        }

        #endregion

        #region Properities

        /// <summary>
        /// 获取或设置与附件关联的事件的唯一标识
        /// </summary>
        public String EventId { get; set; }

        /// <summary>
        /// 获取或设置唯一标识附件的MD5值
        /// </summary>
        public String MD5 { get; set; }

        /// <summary>
        /// 获取或设置附件的文件名
        /// </summary>
        public String Filename { get; set; }

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
