using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
