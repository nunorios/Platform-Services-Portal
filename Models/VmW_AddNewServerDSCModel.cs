﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ObjectsComparer;

namespace Platform_Services_Portal.Models
{
    public class VmW_AddNewServerDSCModel
    {
        public Server Server { get; set; }
        public ChangeRecordModel ChangeRecord { get; set; }
        public IEnumerable<Difference> Differences { get; set; }


        public VmW_AddNewServerDSCModel (Server server, IEnumerable<Difference> differences)
        {
            this.Server = server;
            this.Differences = differences;
        }

        public VmW_AddNewServerDSCModel() { }
    }
}
