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
    /// User Blog 用户角色
    /// </summary>
    [Serializable]
    [SubSonicTableNameOverride("role")]
    public class Role : EntityBase
    {

    }
}
