using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp22.db;

namespace SoftwareInterface
{
   public  class feedback
    {
        [Key]
        public string orderID { get; set; }
        public int rate { get; set; }
    }
}
