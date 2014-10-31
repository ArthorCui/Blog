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
    /// 文章
    /// </summary>
    [Serializable]
    [SubSonicTableNameOverride("post")]
    public class Post : EntityBase
    {

    }
}
