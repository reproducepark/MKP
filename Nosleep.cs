using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MKP
{
    class Nosleep
    {
        private static bool running = false;
        private static Thread noSleepThread;
        private static Form1 formInstance;

        public static void ToggleNoSleep(Form1 form)
        {
            formInstance = form;
            if (!running)
            {
                formInstance.button2.Text = "Stop";
                formInstance.button2.BackColor = System.Drawing.Color.Green; 
                formInstance.button2.ForeColor = System.Drawing.Color.White; 
                running = true;
                noSleepThread = new Thread(NoSleepToggle)
                {
                    IsBackground = true // 백그라운드 스레드로 설정  
                };
                noSleepThread.Start();
            }
            else
            {
                formInstance.button2.Text = "Activate No Sleep";
                formInstance.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
                formInstance.button2.ForeColor = System.Drawing.Color.Black;  
                running = false;
            }
        }

        private static void NoSleepToggle()
        {
            while (running)
            {
                SendKeys.SendWait("{SCROLLLOCK}");
                Thread.Sleep(100);  // Short delay to ensure the key press is registered  
                SendKeys.SendWait("{SCROLLLOCK}");
                Thread.Sleep(300000);  // Wait for 5 minutes  
            }
        }
    }
}
