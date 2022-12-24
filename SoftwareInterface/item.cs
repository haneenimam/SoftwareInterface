using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp22.db;

namespace SoftwareInterface
{
   public  class item
    {
        [Key]
        public string IDcategory { get; set; }
        public string price { get; set; }
    }
}
