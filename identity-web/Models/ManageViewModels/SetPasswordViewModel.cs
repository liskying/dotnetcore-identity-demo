using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace identity_web.Models.ManageViewModels
{
    public class SetPasswordViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "{0}最少{2}个字符,最多{1}个字符.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "新密码")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "密码确认")]
        [Compare("NewPassword", ErrorMessage = "密码不一致.")]
        public string ConfirmPassword { get; set; }

        public string StatusMessage { get; set; }
    }
}
