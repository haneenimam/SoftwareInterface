using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;  

namespace WinFormsApp22.db
{
   public  class Account
    {
      
        public string firstName { get; set; }
        public string lastName { get; set; }
        [Key]
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string Password { get; set; }
        public string Confirmpassword { get; set; }
    }

}
