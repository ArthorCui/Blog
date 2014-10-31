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
    /// public account such as weibo, douban, qq, renren, taobao...
    /// 第三方合作账号
    /// </summary>
    [Serializable]
    [SubSonicTableNameOverride("account")]
    public class Account : EntityBase
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public int Gender { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        [SubSonicStringLength(2048)]
        [SubSonicNullString]
        public string Abstract { get; set; }
    }
}
