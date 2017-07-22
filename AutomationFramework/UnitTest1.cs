using System;
using System.Configuration;
using AutomationFramework.Configuration;
using AutomationFramework.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationFramework
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Iconfig config1 = new AppConfigReader();
            
            Console.WriteLine(config1.GetBrowser());
            Console.WriteLine(config1.GetPassword());
            Console.WriteLine(config1.GetUserName());
            
        }
    }
}
