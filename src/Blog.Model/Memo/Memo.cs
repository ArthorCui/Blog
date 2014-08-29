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
    /// Memo 备忘录（含提醒）
    /// </summary>
    [Serializable]
    [SubSonicTableNameOverride("memo")]
    public class Memo : EntityBase
    {
        [SubSonicStringLength(2048)]
        public string Content { get; set; }

        public DateTime RemindTime { get; set; }

        public User Reminder { get; set; }
    }
}
