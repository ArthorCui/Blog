using OnePiece.Framework.SubSonic;
using SubSonic.SqlGeneration.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Model.User
{
    /// <summary>
    /// User Blog 用户组
    /// </summary>
    [Serializable]
    [SubSonicTableNameOverride("group")]
    public class Group : EntityBase
    {

    }
}
