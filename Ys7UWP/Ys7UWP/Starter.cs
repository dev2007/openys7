using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ys7UWP
{
    public class Starter
    {

        public Starter(String appKey, String secret)
        {
            ManagerContext.Instance.Init(appKey, secret, true);
        }

        public Starter(String appKey, String secret, bool autoRefreshToken)
        {
            ManagerContext.Instance.Init(appKey, secret, autoRefreshToken);
        }


    }
}
