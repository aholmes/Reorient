using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace QuestionAsker
{
    public class LockWorkstation : IDisposable
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        internal static extern void LockWorkStation();

        bool TimerExplicitlyStopped = false;
        Timer ResponseTimer;
        SessionSwitchEventHandler sseh;
        ElapsedEventHandler eeh;

        public LockWorkstation(TimeSpan timeSpan)
        {
            ResponseTimer = new System.Timers.Timer(timeSpan.TotalMilliseconds);

            eeh = new ElapsedEventHandler(OnTimedEvent);
            ResponseTimer.Elapsed += eeh;

            ResponseTimer.AutoReset = false;
            ResponseTimer.Enabled = true;

            sseh = new SessionSwitchEventHandler(SysEventsCheck);
            SystemEvents.SessionSwitch += sseh;

        }

        public void RestartTimeout()
        {
            ResponseTimer.Stop();
            ResponseTimer.Start();
        }

        public void StopTimeout()
        {
            TimerExplicitlyStopped = true;

            ResponseTimer.Stop();
            ResponseTimer.Enabled = false;
        }

        void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            LockWorkstation.LockWorkStation();
        }
        void SysEventsCheck(object sender, SessionSwitchEventArgs e)
        {
            if (TimerExplicitlyStopped) return;

            switch (e.Reason)
            {
                case SessionSwitchReason.SessionLock: /* Lock */ break;
                case SessionSwitchReason.SessionUnlock:
                    ResponseTimer.Enabled = true;
                    ResponseTimer.Start();
                    break;
            }
        }

        public void Dispose()
        {
            SystemEvents.SessionSwitch -= sseh;
        }
    }
}
