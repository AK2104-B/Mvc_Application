using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Application_0._0._1.Models.Model
{
   public class UserModel
    {
        public int id { get; set; }
        [Display(Name ="First Name")]
        [Required]
        [DataType(DataType.Text)]
        public string Fname { get; set; }

        [Display(Name ="Last Name")]
        [Required]
        [DataType(DataType.Text)]
        public string Lname { get; set; }

        [Display(Name = "Email")]
        [Required]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^[A-Za-z0-9]+@([a-zA-Z]+\\.)+[a-zA-Z]{2,6}]&")]
        public string email { get; set; }

        [Display(Name = "Password")]
        [Required]
        [DataType(DataType.Password)]
        public string pass { get; set; }


        public string img { get; set; }

        [Display(Name = "Confirm Password")]
        [Required]
        [DataType(DataType.Password)]
        [Compare("pass")]
        public string confpass { get; set; }

        [Display(Name = "Add Image")]
        [Required]
        public HttpPostedFileBase imgsave { get; set; }
    }
}
