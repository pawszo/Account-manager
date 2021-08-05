using AccountMaker.Models.Abstract;
using AccountMaker.Models.Interface;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountMaker.Models.Actions
{
    public class OnetLoginAction : ActionBase
    {
        public OnetLoginAction(IItem target, IDictionary<string, string> settings) : base(target, settings)
        { }
        public override bool Act(IWebDriver driver)
        {
            bool isSuccess = false;
            int attempts = Settings.AttemptsBeforeLeave;
            while(!isSuccess || attempts<1)
            {
                try
                {
                    driver.Navigate().GoToUrl(@"https://www.onet.pl/poczta");
                    driver.Manage().Window.FullScreen();
                    var js = driver as IJavaScriptExecutor;
                    System.Threading.Thread.Sleep(5000);
                    new OnetBannerCloseAction(null, null).Act(driver);
                    var submitButton = driver.FindElements(By.ClassName("loginButton")).First();
                    
                    js.ExecuteScript("document.getElementById(\"mailFormPassword\").value = \"" + _settings["password"] + "\"");
                    js.ExecuteScript("document.getElementById(\"mailFormLogin\").value = \"" + _settings["login"] + "\"");
                    var inputs = driver.FindElements(By.XPath(@"//input[@class='loginButton']"));
                    inputs[0].Click();
                    isSuccess = true;
                }
                catch
                {
                    isSuccess = false;
                }
                attempts--;
            }
            
            return isSuccess;
            
        }
    }
}
