﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountMaker.DTOs
{
    public class AccountEntryDto
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string BirthDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
