using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ServiceExample
{
    public partial class ServiceExample : ServiceBase
    {
        public ServiceExample()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            EventLog.WriteEntry("The NHL-Stenden service has started!", EventLogEntryType.Information);
        }

        protected override void OnStop()
        {
            EventLog.WriteEntry("The NHL-Stenden service has stopped!", EventLogEntryType.Information);
        }
    }
}
