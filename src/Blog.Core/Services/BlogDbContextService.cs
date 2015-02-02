using Blog.Common;
using OnePiece.Framework.SubSonic;
using SubSonic.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core
{
    public class BlogDbContextService : IBlogDbContext
    {
        public string ConnectionStringName
        {
            get { return ConnectStrings.BLOG_MYSQL_CONNECTSTRING; }
        }

        public SubSonic.Repository.IRepository DbContext
        {
            get { return new SimpleRepository(this.ConnectionStringName, SimpleRepositoryOptions.RunMigrations); }
        }
    }
}
