﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Golf.Engine
{
    /// <summary>
    /// The AppRuntime class determents where the user are located in the application.
    /// Which segemts of code to run, stand alone or simultatnious.
    /// </summary>
    public class AppRuntime
    {
        private bool Running { get; set; }
        public AppRuntime()
        {
            Running = true;
        }

        ~AppRuntime()
        {

        }

        public void RunTime()
        {
            while(Running == true)
            {
                
            }
        }

        private void GetUserAppActivity()
        {

        }
    }
}
