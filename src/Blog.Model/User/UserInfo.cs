using OnePiece.Framework.SubSonic;
using SubSonic.SqlGeneration.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Model
{
    /// <summary>
    /// User Blog用户 扩展信息
    /// </summary>
    [Serializable]
    [SubSonicTableNameOverride("user_info")]
    public class UserInfo : EntityBase
    {
        public int UserId { get; set; }

        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime BirthTime { get; set; }

        /// <summary>
        /// 教育信息
        /// </summary>
        [SubSonicStringLength(64)]
        [SubSonicNullString]
        public string EducationInfo { get; set; }

        /// <summary>
        /// 工作信息
        /// </summary>
        [SubSonicStringLength(64)]
        [SubSonicNullString]
        public string JobInfo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [SubSonicStringLength(512)]
        [SubSonicNullString]
        public string Comment { get; set; }
    }
}
