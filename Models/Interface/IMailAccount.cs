using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountMaker.Models.Interface
{
    interface IMailAccount
    {
        void SendEmail(Email email);
    }
}
