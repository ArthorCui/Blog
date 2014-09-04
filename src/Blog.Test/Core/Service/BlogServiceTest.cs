using Blog.Core;
using Blog.Model;
using OnePiece.Framework.SubSonic;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Blog.Test.Core.Service
{
    public class BlogServiceTest : TestBase
    {
        public IBlogDbContext dbContext
        {
            get
            {
                if (_dbContext == null)
                {
                    _dbContext = ObjectFactory.GetInstance<IBlogDbContext>();
                }
                return _dbContext;
            }
        } private IBlogDbContext _dbContext;

        [Fact(Skip="SubSonic")]
        public void model_generate_use_subsonic_test()
        {
            var talkModel = new Talk();
            var ret = dbContext.Add<Talk>(talkModel);

            Console.WriteLine(ret);

            var tbModel = dbContext.Single<Talk>(x => x.Id == 1);
            Assert.Equal(1, (int)tbModel.Status);
        }
    }
}
