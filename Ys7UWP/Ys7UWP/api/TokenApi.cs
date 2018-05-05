using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ys7UWP.api
{
    public class TokenApi
    {
        public async static void GetToken()
        {
            //TODO:获取token，然后设置
            await Task.Run(() =>
            {
                ManagerContext.Instance.AccessToken = "TODO";
            });
        }
    }
}
