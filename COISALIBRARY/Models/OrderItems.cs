using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COISALIBRARY.Models
{
    public class OrderItems
    {

        [Key]
        [MaxLength(100)]
        public string id { get; set; }
        public string strName { get; set; }
        public double strQty { get; set; }
        public string strImageUrl { get; set; }
        public double strPrice { get; set; }
        public string strOrderId { get; set; }
      public  bool isdeleted { get; set; }

    }
}
