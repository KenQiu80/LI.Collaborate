using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LI.Collaborate.Models.Enum
{
    public enum TeamMemberRole
    {
        /// <summary>
        /// 代表了实施事件的团队组长
        /// </summary>
        Leader,

        /// <summary>
        /// 代表了实施事件的团队成员
        /// </summary>
        Member,

        /// <summary>
        /// 代表了事件实施成果的验收方
        /// </summary>
        Accepter
    }
}
