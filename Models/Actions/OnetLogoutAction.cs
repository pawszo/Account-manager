using AccountMaker.Models.Abstract;
using AccountMaker.Models.Interface;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountMaker.Models.Actions
{
    public class OnetLogoutAction : ActionBase
    {
        public OnetLogoutAction(IItem target, IDictionary<string, string> settings) : base(target, settings)
        { }
        ////a[contains(@href, 'logout')]
        public override bool Act(IWebDriver driver)
        {
            bool isSuccess = false;
            int attempts = Settings.AttemptsBeforeLeave;
            while (!isSuccess || attempts < 1)
            {
                try
                {
                    var jsBuilder = new StringBuilder();
                    jsBuilder.Append("document.evaluate(");
                    jsBuilder.Append("\"//a[contains(@href, 'logout')]\", ");
                    jsBuilder.Append("document, null, ");
                    jsBuilder.Append("XPathResult.FIRST_ORDERED_NODE_TYPE, null)");
                    jsBuilder.Append(".singleNodeValue.click();");
                    (driver as IJavaScriptExecutor).ExecuteScript(jsBuilder.ToString());

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
