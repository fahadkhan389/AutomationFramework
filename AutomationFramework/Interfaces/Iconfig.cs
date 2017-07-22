using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.Configuration;

namespace AutomationFramework.Interfaces
{
    public interface Iconfig
    {   BrowserType GetBrowser();
        string GetUserName();
        string GetPassword();
    }
}
