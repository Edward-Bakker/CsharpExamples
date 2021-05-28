using System.ServiceProcess;

namespace ServiceExample
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new ServiceExample()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
