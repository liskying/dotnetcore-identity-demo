using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq; 
using System.Threading.Tasks; 
using Microsoft.AspNetCore.Identity;

namespace identity_web.Data.Domain {
    /// <summary>
    /// 用户令牌
    /// </summary>
    [Table("TyUserToken")]
    public class TyUserToken:IdentityUserToken < string >  {
        /// <summary>
        /// Id
        /// </summary>
        public string Id {get; set; }
        /// <summary>
        /// 令牌提供者
        /// </summary>
        public override string LoginProvider {get => base.LoginProvider; set => base.LoginProvider = value; }
        /// <summary>
        /// 令牌名称
        /// </summary>
        public override string Name {get => base.Name; set => base.Name = value; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public override string UserId {get => base.UserId; set => base.UserId = value; }
        /// <summary>
        /// 令牌信息
        /// </summary>
        public override string Value {get => base.Value; set => base.Value = value; }
    }
}
