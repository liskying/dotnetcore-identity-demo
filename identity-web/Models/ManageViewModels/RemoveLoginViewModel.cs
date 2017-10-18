using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace identity_web.Models.ManageViewModels
{
    public class RemoveLoginViewModel
    {
        //登录提供者
        public string LoginProvider { get; set; }
        //提供者Key
        public string ProviderKey { get; set; }
    }
}
