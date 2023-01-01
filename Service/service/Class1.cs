using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;

namespace service
{
    internal class Class1
    {
        public static string p = "flag";
        static void Main(string[] args)
        {
            p = args[0];
            svc1.RunService();
        }

    }

    public partial class svc1 : ServiceBase
    {
        public static void RunService()
        {
            Run(new svc1());
        }

        protected override void OnStart(string[] args)
        {
            System.Diagnostics.Process.Start(Class1.p);
        }

        protected override void OnStop()
        {
        }
    }
}
