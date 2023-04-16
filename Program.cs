using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace media
{
    static class Program
    {
        [DllImport("shcore.dll")]
        private static extern int SetProcessDpiAwareness(int awareness);

        private const int PROCESS_SYSTEM_DPI_AWARE = 1;
        private const int PROCESS_PER_MONITOR_DPI_AWARE = 2;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Set DPI awareness
            if (Environment.OSVersion.Version.Major >= 6)
            {
                try
                {
                    SetProcessDpiAwareness(PROCESS_PER_MONITOR_DPI_AWARE);
                }
                catch (EntryPointNotFoundException)
                {
                    // Fall back to SetProcessDPIAware() if SetProcessDpiAwareness() is not found
                    SetProcessDPIAware();
                }
            }

            Application.Run(new FormTest());
        }

        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
