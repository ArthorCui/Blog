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
        public string Name { get; set; }

        public string NickName { get; set; }

        public int Gender { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        [SubSonicStringLength(2048)]
        [SubSonicNullString]
        public string Abstract { get; set; }
    }
}
