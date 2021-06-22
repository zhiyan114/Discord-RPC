using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sentry;

namespace Discord_RPC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (SentrySdk.Init(o =>
            {
                o.Dsn = "https://5e25cf80720b4a35ad1447e345ac633c@o125145.ingest.sentry.io/5825567";
#if DEBUG
                o.Debug = true;
                o.Environment = "Debug";
                o.TracesSampleRate = 0.5;
#elif RELEASE
                o.Environment = "Release";
                o.Release = "Discord-RPC@1.0.0";
                o.TracesSampleRate = 0.1;
#endif
                o.BeforeSend = a => PrepareEvent(a);


            }))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
                Application.ThreadException += ExceptionManager;
                Application.Run(new Form1());
            }
        }
        static bool ShowReport = true;
        private static void ExceptionManager(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            SentryId EVTID = SentrySdk.CaptureException(e.Exception);
            if(ShowReport)
            {
                using (UserReport ReportUI = new UserReport())
                {
                    ReportUI.MainEventId = EVTID;
                    if (ReportUI.ShowDialog() == DialogResult.No)
                    {
                        ShowReport = false;
                    }
                }
            }
            
        }

        static public SentryEvent PrepareEvent(SentryEvent e)
        {
            e.SetTag("Ignore Report", (!ShowReport).ToString());
            return e;
        }
    }
}
