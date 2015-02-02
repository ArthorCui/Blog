using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnePiece.Framework.SubSonic;
using SubSonic.SqlGeneration.Schema;

namespace Blog.Model.Tag
{
    /// <summary>
    /// 标签
    /// </summary>
    [Serializable]
    [SubSonicTableNameOverride("tag")]
    public class Tag : EntityBase
    {
        [SubSonicStringLength(64)]
        public string Name { get; set; }
    }
}
