using AccountMaker.Models.Abstract;
using AccountMaker.Models.Interface;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountMaker.Models.Actions
{
    public class InstagramSubscribeAction : ActionBase
    {
        public InstagramSubscribeAction(IItem target, IDictionary<string, string> settings) : base(target, settings)
        { }
        public override bool Act(IWebDriver driver)
        {
            bool isSuccess;
            try
            {
                driver.Navigate().GoToUrl(_target.URL);
                //click subscribe
                isSuccess = true;
            }
            catch
            {
                isSuccess = false;
            }
            return isSuccess;
        }
    }
}
