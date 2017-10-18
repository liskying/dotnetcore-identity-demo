using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace identity_web.Data.Domain
{
    /// <summary>
    /// 第三方登录
    /// </summary>
    [Table("TyUserLogin")]
    public class TyUserLogin : IdentityUserLogin<string>
    {
        
        /// <summary>
        /// Id
        /// </summary>
        public string Id{get;set;}

        /// <summary>
        /// 第三方登录提供者
        /// </summary>
        public override string LoginProvider { get => base.LoginProvider; set => base.LoginProvider = value; }
        /// <summary>
        /// 第三方登录显示名
        /// </summary>
        public override string ProviderDisplayName { get => base.ProviderDisplayName; set => base.ProviderDisplayName = value; }
        /// <summary>
        /// 第三方登录提供Key
        /// </summary>
        public override string ProviderKey { get => base.ProviderKey; set => base.ProviderKey = value; }
        /// <summary>
        /// 用户 ID 
        /// </summary>
        public override string UserId { get => base.UserId; set => base.UserId = value; }
    }
}
