using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace identity_web.Models.AccountViewModels
{
    public class ResetPasswordViewModel
    {
        [Display(Name = "邮箱")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = " {0}最少{2}个字符,最多{1}个字符.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "密码不一致.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }
}
