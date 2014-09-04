using Blog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Blog.Test
{
    public class TestBase : IUseFixture<TestBase>
    {
        public void SetFixture(TestBase data)
        {
            Bootstrapper.Start();
        }
    }
}
