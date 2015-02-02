using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnePiece.Framework.SubSonic;
using SubSonic.SqlGeneration.Schema;

namespace Blog.Model.Relation
{
    /// <summary>
    /// 说说-标签 关系表
    /// </summary>
    [Serializable]
    [SubSonicTableNameOverride("talk_tag")]
    public class TalkTag : EntityBase
    {

    }
}
