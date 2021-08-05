using AccountMaker.DTOs;
using AccountMaker.Models.Abstract;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountMaker.Services.Abstract
{
    public abstract class AccountServiceBase
    {
        public IWebDriver WebDriver { get; set; }
        public abstract bool CreateAccount(AccountEntryDto entry);
        public void ExecutePendingActions(AccountBase account)
        {
            while(account.PendingActions.TryDequeue(out ActionBase action))
            {
                action.Act(WebDriver);
            }
        }
    }
}
