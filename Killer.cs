using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKP
{
    class Killer
    {
        static void SuspendProcessByName(string processName)
        {
            foreach (var process in Process.GetProcessesByName(processName))
            {
                SuspendProcess(process);
            }
        }

        static void KillProcessByName(string processName)
        {
            foreach (var process in Process.GetProcessesByName(processName))
            {
                process.Kill();
            }
        }

        public static void Func()
        {
            for (int i = 0; i < 15; i++)
            {
                SuspendProcessByName("qukapttp");
                KillProcessByName("nfowjxyfd");
                KillProcessByName("nhfneczzm");
            }
        }

        // This method requires P/Invoke to suspend a process
        [System.Runtime.InteropServices.DllImport("ntdll.dll", SetLastError = true)]
        private static extern int NtSuspendProcess(IntPtr processHandle);

        private static void SuspendProcess(Process process)
        {
            var handle = process.Handle;
            NtSuspendProcess(handle);
        }
    }
}
