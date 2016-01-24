using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.ServiceProcess;
using System.Text;

namespace ProgramControlling
{
    public partial class ControllingService : ServiceBase
    {
        public ControllingService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            SystemEvents.PowerModeChanged += SystemEvents_PowerModeChanged;
        }

        private void SystemEvents_PowerModeChanged(object sender, PowerModeChangedEventArgs e)
        {
            switch (e.Mode)
            {
                case PowerModes.Resume:
                    File.AppendAllText("D:/log.txt", DateTime.Now.ToString("HH:mm:ss.fff", System.Globalization.DateTimeFormatInfo.InvariantInfo) + ": Resume");
                    break;
                case PowerModes.Suspend:
                    File.AppendAllText("D:/log.txt", DateTime.Now.ToString("HH:mm:ss.fff", System.Globalization.DateTimeFormatInfo.InvariantInfo) + ": Suspend");
                    break;
            }
        }

        internal void OnDebug()
        {
            OnStart(null);
        }

        protected override void OnStop()
        {
        }
    }
}
