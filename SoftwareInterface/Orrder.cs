using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoftwareInterface
{
    public class Orrder
    {
        //  public int ID { get; set; }
        [Key]
        public string city { get; set; }

        public string Area { get; set; }

        public string Paymentmethod { get; set; }
        public int Cardnumber { get; set; }
        public int Totalamount { get; set; }
    }
}
