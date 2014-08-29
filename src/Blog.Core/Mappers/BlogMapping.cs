using AutoMapper;
using Blog.Model;
using OnePiece.Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core
{
    public class BlogMapping : IEntityMapper
    {
        public void Config()
        {
            Mapper.CreateMap<Talk, TalkView>()
                .IgnoreAllNonExisting();
        }
    }
}
