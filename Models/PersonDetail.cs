using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AccountMaker.Models
{
    public class PersonDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public long Id { get; set; }
        public string FullName { get; set; }
        public List<string> EmailAddresses { get; } = new List<string>();
        public List<string> Nicknames { get; } = new List<string>();
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public List<Address> Addresses { get; } = new List<Address>();
        

    }
    public enum Gender
    {
        Male, Female, TransMale, TransFemale, Other
    }
}
