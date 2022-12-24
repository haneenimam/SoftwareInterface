using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WinFormsApp22.db;

namespace SoftwareInterface
{
   public  class User
    {
        [Key]
        public string ID { get; set; }
        public string address { get; set; }
        
      
    }
}
