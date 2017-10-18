using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Threading.Tasks; 

namespace identity_web.db.domain {
    /// <summary>
    /// 用户令牌
    /// </summary>
    public class TyUserToken:Microsoft.AspNetCore.Identity.IdentityUserToken < string >  {
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
