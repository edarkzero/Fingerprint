using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FingerprintClient
{
    class ThreadManager
    {
        private Thread oThread;
        private SetTextCallback callback;

        public ThreadManager(SetTextCallback setCallBack)
        {
            callback = setCallBack;
            oThread = new Thread(new ThreadStart(Start));            
            oThread.Start();
        }

        public void Stop()
        {
            if(oThread.IsAlive)
                oThread.Abort();
        }

        public void Start()
        {
            SynchronousSocketClient.StartListening(callback);
        }
    }
}
