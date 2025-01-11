using Common.Domain;
using Microsoft.VisualBasic.ApplicationServices;
using SysOp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Controller
    {
        private static Controller instance;
        public static Controller Instance
        {
            get
            {
                if (instance == null) instance = new Controller();
                return instance;
            }
        }

        internal object LoginUser(Frizer user)
        {
            SystemOperationBase so = new LogInSysOp(user);
            so.Execute();
            return ((LogInSysOp)so).Result;
        }
    }
}
