using AccountMaker.DTOs;
using AccountMaker.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AccountMaker.Services
{
    public class OnetAccountService : AccountServiceBase
    {
        public override bool CreateAccount(AccountEntryDto entry)
        {
            bool isSuccess;
            var driver = new ChromeDriver();
            try
            {
                driver.Navigate().GoToUrl(@"http://poczta.onet.pl/");
                if(driver.FindElementsByClassName(@"cmp-button_button cmp-intro_acceptAll").Count > 0)
                {
                    driver.FindElementsByClassName(@"cmp-button_button cmp-intro_acceptAll").First().Click();
                }
                
                driver.FindElementByClassName("createAccount").Click();


                isSuccess = true;
            }
            catch
            {
                isSuccess = false;
            }
            finally
            {
                driver.Quit();
            }
            return isSuccess;
        }
            
    }
}
