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
    /// 树洞、自言自语、说说
    /// </summary>
    [Serializable]
    [SubSonicTableNameOverride("talk")]
    public class Talk : EntityBase
    {
        [SubSonicStringLength(2048)]
        [SubSonicNullString]
        public string Content { get; set; }
    }
}
