using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core
{
    public class Bootstrapper
    {
        private static bool _hasBeenIntialized = false;
        internal const string CURRENT_ASSEMBLY = "Blog.Core";

        public static void Start()
        {
            if (!_hasBeenIntialized)
            {
                _hasBeenIntialized = true;

            }
        }
    }
}
