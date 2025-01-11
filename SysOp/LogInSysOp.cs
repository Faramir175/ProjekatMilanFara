using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp
{
    public class LogInSysOp:SystemOperationBase
    {
        private Frizer user;
        public List<Frizer> Result { get; set; }
        public LogInSysOp(Frizer user)
        {
            this.user = user;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetCriteria(user).OfType<Frizer>().ToList();

        }
    }
}
