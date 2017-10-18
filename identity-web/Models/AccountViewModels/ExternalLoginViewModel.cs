using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace identity_web.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Display(Name = "邮箱")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
