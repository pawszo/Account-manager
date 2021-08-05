using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountMaker.Models
{
    public class Email
    {
        public string Sender { get; set; }
        public List<string> Receivers { get; } = new List<string>();
        public List<string> CcReceivers { get; } = new List<string>();
        public string Title { get; set; }
        public string Body { get; set; }
        /// <summary>
        /// Signature such as "Best regards, Name Surname, footer"
        /// </summary>
        public string Signature { get; set; }
    }
}
