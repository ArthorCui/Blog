using OnePiece.Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core
{
    public class CommonRegistry : BasicRegistry
    {
        public override void Register()
        {
            For<IBlogDbContext>().Use<BlogDbContextService>();
            For<IBlogService>().Use<BlogService>();
        }
    }
}
