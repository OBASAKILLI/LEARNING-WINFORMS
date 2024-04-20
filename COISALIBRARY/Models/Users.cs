using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COISALIBRARY.Models
{
    public class Users
    {
        [Key]
        [MaxLength(100)]
        public string strUserId { get; set; }
        [Required]
        [DisplayName("Name")]
        public string strUsername { get; set; }
        [Required]
        [DisplayName("Email")]
        public string strEmail { get; set; }
        [Required]
        [DisplayName("Phone")]
        public string strPhone { get; set; }
        [Required]
        public string password { get; set; }
        public Role  Role { get; set; }

     
    }
    public enum Role
    {
        Supper_Admin,
        Admin,
        Client
    }
}
