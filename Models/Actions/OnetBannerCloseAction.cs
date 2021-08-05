using AccountMaker.Models.Abstract;
using AccountMaker.Models.Interface;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountMaker.Models.Actions
{
    public class OnetBannerCloseAction : ActionBase
    {
        public OnetBannerCloseAction(IItem target, IDictionary<string, string> settings) : base(target, settings)
        { }
        public override bool Act(IWebDriver driver)
        {
            bool isSuccess = false;
            int attempts = Settings.AttemptsBeforeLeave;
            while(!isSuccess || attempts < 1)
            {
                try
                {
                    (driver as IJavaScriptExecutor).ExecuteScript("document.getElementsByClassName(\"cmp-button_button cmp-intro_acceptAll \")[0].click()");
                    isSuccess = true;
                }
                catch
                {
                    isSuccess = false;
                }
                attempts--;
                System.Threading.Thread.Sleep(500);
            }
            return isSuccess;

        }
    }
}
