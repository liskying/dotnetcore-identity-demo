using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace identity_web.db.domain
{
    /// <summary>
    /// 用户角色对应表
    /// </summary>
    public class TyUserRole : Microsoft.AspNetCore.Identity.IdentityUserRole<string>
    {
        /// <summary>
        /// 角色ID
        /// </summary>
        public override string RoleId { get => base.RoleId; set => base.RoleId = value; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public override string UserId { get => base.UserId; set => base.UserId = value; }
    }
    
}
