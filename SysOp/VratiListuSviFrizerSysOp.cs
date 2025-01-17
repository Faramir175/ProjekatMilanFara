﻿using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp
{
    public class VratiListuSviFrizerSysOp : SystemOperationBase
    {
        public List<Frizer> Result { get; set; }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAll(new Frizer()).OfType<Frizer>().ToList();

        }
    }
}
