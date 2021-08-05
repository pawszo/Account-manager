using AccountMaker.Models.Abstract;
using AccountMaker.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountMaker.Models.Accounts
{
    public class OnetAccount : AccountBase, IMailAccount
    {
        public void SendEmail(Email email)
        {
            throw new NotImplementedException();
        }
    }
}
