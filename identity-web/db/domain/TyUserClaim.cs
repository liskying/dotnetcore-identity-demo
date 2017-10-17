using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace identity_web.db.domain
{
    /// <summary>
    /// 用户声明
    /// </summary>
    public class TyUserClaim: Microsoft.AspNetCore.Identity.IdentityUserClaim<string>
    {
        /// <summary>
        /// 用户声明标识
        /// </summary>
        public override int Id { get => base.Id; set => base.Id = value; }
        /// <summary>
        /// 用户声明类型
        /// </summary>
        public override string ClaimType { get => base.ClaimType; set => base.ClaimType = value; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public override string UserId { get => base.UserId; set => base.UserId = value; }
        /// <summary>
        /// 用户声明值
        /// </summary>
        public override string ClaimValue { get => base.ClaimValue; set => base.ClaimValue = value; }
    }
}
