
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COISALIBRARY.Models
{
    public class Product_Category
    {
        [Key]
        [MaxLength(50)]

        public string strCatId { get; set; }
        [Required]
        [DisplayName("Product category")]
        public string strCatName { get; set; }
        [Required]
        [DisplayName("Description")]
        public string strDescription { get; set; }
        public string strCatPhoto { get; set; }
        
    }
}
