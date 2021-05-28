using System.Diagnostics;
using System.ServiceProcess;

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
