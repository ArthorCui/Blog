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
    /// User Blog用户
    /// </summary>
    [Serializable]
    [SubSonicTableNameOverride("user")]
    public class User : EntityBase
    {
        public int AccountId { get; set; }

        public string Name { get; set; }

        public string NickName { get; set; }

        public string Email { get; set; }
    }
}
