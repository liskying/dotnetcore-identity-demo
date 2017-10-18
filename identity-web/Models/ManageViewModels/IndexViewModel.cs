using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace identity_web.Models.ManageViewModels
{
    //个性设置模型
    public class IndexViewModel
    {
        [Display(Name = "账号")]
        public string Username { get; set; }

        //密码是否确认
        public bool IsEmailConfirmed { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "邮箱")]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "手机号")]
        public string PhoneNumber { get; set; }

        public string StatusMessage { get; set; }
    }
}
