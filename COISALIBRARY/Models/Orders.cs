using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COISALIBRARY.Models
{
    public class Orders
    {
        [Key]
        [MaxLength(50)]
        public string docref { get; set; }
        public string user_id { get; set; }
        public string order_no { get; set; }
        public DateTime date { get; set; }
        public double amount { get; set; }
        [Required]
        [DisplayName("Phone No :")]
        public string strphone { get; set; }
        public bool shipped_status { get; set; }
        
        public bool isdeleted { get; set; }
        [Required]
        [DisplayName("County  :")]
        public string County { get; set; }
        [Required]
        [DisplayName("Region  :")]
        public string Region { get; set; }
    }
}
