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
    public class OnetSendmailAction : ActionBase
    {
        public OnetSendmailAction(IItem target, IDictionary<string, string> settings) : base(target, settings)
        {
        }

        private void AddMailTitle(IWebDriver driver, string receiverMailAddress)
        {
            string js = new StringBuilder()
            .Append("document.evaluate(")
            .Append("\"//label[text() = 'Temat']//following-sibling::div/descendant::input\", ")
            .Append("document, null, ")
            .Append("XPathResult.FIRST_ORDERED_NODE_TYPE, null)")
            .Append(".singleNodeValue.value = \"" + receiverMailAddress + "\";")
            .ToString();
            (driver as IJavaScriptExecutor).ExecuteScript(js);
        }

        private void ClickNewMail(IWebDriver driver)
        {
            var jsBuilder = new StringBuilder();
            jsBuilder.Append("document.evaluate(");
            jsBuilder.Append("\"//*[text()='Napisz wiadomość']\", ");
            jsBuilder.Append("document, null, ");
            jsBuilder.Append("XPathResult.FIRST_ORDERED_NODE_TYPE, null)");
            jsBuilder.Append(".singleNodeValue.click();");
            (driver as IJavaScriptExecutor).ExecuteScript(jsBuilder.ToString());
            System.Threading.Thread.Sleep(1500);
        }
        //private void 
            

        public override bool Act(IWebDriver driver)
        {
            bool isSuccess;
            try
            {
                //document.evaluate("//*[text()='Napisz wiadomość']", document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue.click()
                ClickNewMail(driver);

                
                var jsBuilder = new StringBuilder();
                jsBuilder.Append("document.evaluate(");
                jsBuilder.Append("\"//input[@type = 'email']\", ");
                jsBuilder.Append("document, null, ");
                jsBuilder.Append("XPathResult.FIRST_ORDERED_NODE_TYPE, null)");
                jsBuilder.Append(".singleNodeValue.value = \""+_settings["receiver"]+"\";");
                (driver as IJavaScriptExecutor).ExecuteScript(jsBuilder.ToString());

                AddMailTitle(driver, _settings["receiver"]);


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
