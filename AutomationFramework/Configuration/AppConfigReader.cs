﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.Interfaces;
using AutomationFramework.Settings;

namespace AutomationFramework.Configuration
{
    public class AppConfigReader : Iconfig
    {
        public BrowserType GetBrowser()
        {
            string browser = ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
           return (BrowserType) Enum.Parse(typeof(BrowserType), browser);

        }

        public string GetPassword()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Password);
        }

        public string GetUserName()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Username);

        }
    }
}
