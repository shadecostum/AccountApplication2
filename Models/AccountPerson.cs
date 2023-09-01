using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApplication2.Models
{
    [Serializable]
    internal class AccountPerson
    {
        
        public string AccountName { get; set; }
        public string BankName { get; set; }
        public int Balance { get; set; }

       
    }
}
