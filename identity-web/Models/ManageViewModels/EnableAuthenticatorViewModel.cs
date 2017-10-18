using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace identity_web.Models.ManageViewModels
{
    public class EnableAuthenticatorViewModel
    {
            //认证码
            [Required]
            [StringLength(7, ErrorMessage = "{0}最少{2}个字符,最多{1}个字符.", MinimumLength = 6)]
            [DataType(DataType.Text)]
            [Display(Name = "认证码")]
            public string Code { get; set; }

            [ReadOnly(true)]
            public string SharedKey { get; set; }

            public string AuthenticatorUri { get; set; }
    }
}
