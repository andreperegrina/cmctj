using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmctj.Utils
{
    public class SessionData
    {
        private static Hashtable instance;
        private static readonly object TheLock = new Object();
        public static Hashtable Instance
        {
            get
            {
                lock (TheLock)
                {
                    if (instance == null)
                    {
                        instance = new Hashtable();
                    }
                }
                return instance;
            }
        }
    }
}
