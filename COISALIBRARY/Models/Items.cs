using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COISALIBRARY.Models
{
    public class Items
    {
        [Key]
        [MaxLength(50)]
        public string strItemId { get; set; }
        [Required]
        [DisplayName("Product name")]
        public string strItemName { get; set; }
        [Required]
        public string strCategoryId { get; set; }
        [Required]
        [DisplayName("Price")]
        public double strPrice { get; set; }
        [Required]
        [DisplayName("Previous price")]
        public double strPreviousPrice { get; set; }
        [Required]
        [DisplayName("Product description")]
        public string strDesc { get; set; }
        [Required]
        [DisplayName("Quantity")]
        public double strQty { get; set; }
        public string strPhoto { get; set; }
      public  bool isdeleted { get; set; }
        
    }
}
