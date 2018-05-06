using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ys7UWP.models
{
    public class AppData
    {
        public String AppKey { get; private set; }
        public String Secret { get; private set; }

        public AppData(String appkey, String secret)
        {
            this.AppKey = appkey;
            this.Secret = secret;
        }
    }
}
