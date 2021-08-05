using AccountMaker.Models.Abstract;
using AccountMaker.Models.Interface;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountMaker.Models.Actions
{
    public class InstagramCommentAction : ActionBase
    {
        public InstagramCommentAction(IItem target, IDictionary<string, string> settings) : base(target, settings)
        {
        }
        public override bool Act(IWebDriver driver)
        {
            bool isSuccess;
            try
            {
                driver.Navigate().GoToUrl(_target.URL);
                EnterComment(_settings["comment"]);
                //driver.click on button();
                isSuccess = true;
            }
            catch
            {
                isSuccess = false;
            }
            return isSuccess;


        }

        private void EnterComment(string text)
        {
            //todo
        }
    }
}
