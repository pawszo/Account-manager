using AccountMaker.Models.Interface;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountMaker.Models.Abstract
{
    public abstract class ActionBase
    {
        protected IItem _target;
        protected IDictionary<string, string> _settings;
        public abstract bool Act(IWebDriver driver);
        public Queue<ActionBase> InternalActions { get; } = new Queue<ActionBase>();
        public ActionBase(IItem target, IDictionary<string, string> settings)
        {
            _target = target;
            _settings = settings;
        }
    }
}
