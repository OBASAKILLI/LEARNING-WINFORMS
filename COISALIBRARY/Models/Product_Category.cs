
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COISALIBRARY.Models
{
    public class Product_Category
    {
        [Key]
        [MaxLength(50)]
        public string strId { get; set; }
        [Required]
        [DisplayName("Product category")]
        public string strCatName { get; set; }
        public string strCatPhoto { get; set; }
        public bool Isdeleted { get; set; }

       
    }
}
