using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ys7UWP.api;
using Ys7UWP.models;

namespace Ys7UWP
{
    public class ManagerContext
    {
        delegate void GetTokenDelegate();
        private AppData appData;
        private System.Threading.Timer tokenTimer;
        public String AccessToken { get; set; }
        public bool AutoRefreshToken { get; set; }

        private static ManagerContext _instance;
        public static ManagerContext Instance
        {
            get
            {
                if (null == _instance)
                {
                    _instance = new ManagerContext();
                }
                return _instance;
            }
        }

        private ManagerContext()
        {

        }

        public void Init(String appKey,String secret,bool autoRefreshToken)
        {
            appData = new AppData(appKey, secret);
            this.AutoRefreshToken = autoRefreshToken;
            GetToken();
        }

        private void GetToken()
        {
                InternalGetToken();
        }

        private void InternalGetToken()
        {
            //TODO:先判断token的存在性和时效性，然后调用token api刷新token。
            if (AutoRefreshToken)
            {
                tokenTimer = new System.Threading.Timer(new System.Threading.TimerCallback(ThreadMethod), null, 0, 1);
            }
        }

        private void ThreadMethod(object state)
        {
            GetTokenDelegate deg = new GetTokenDelegate(TokenApi.GetToken);
        }
    }
}
