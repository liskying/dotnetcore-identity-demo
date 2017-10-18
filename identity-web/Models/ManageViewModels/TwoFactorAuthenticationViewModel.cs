using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace identity_web.Models.ManageViewModels
{
    public class TwoFactorAuthenticationViewModel
    {
        //是否已认证
        public bool HasAuthenticator { get; set; }

        //恢复码
        public int RecoveryCodesLeft { get; set; }

        //是否启用双重认证
        public bool Is2faEnabled { get; set; }
    }
}
