using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace identity_web.db.domain
{
    /// <summary>
    /// 角色声明
    /// </summary>
    public class TyRoleClaim : Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>
    {
        /// <summary>
        /// 角色声明ID
        /// </summary>
        public override int Id { get => base.Id; set => base.Id = value; }
        /// <summary>
        /// 角色声明类型
        /// </summary>
        public override string ClaimType { get => base.ClaimType; set => base.ClaimType = value; }
        /// <summary>
        /// 角色声明信息
        /// </summary>
        public override string ClaimValue { get => base.ClaimValue; set => base.ClaimValue = value; }
        /// <summary>
        /// 角色ID
        /// </summary>
        public override string RoleId { get => base.RoleId; set => base.RoleId = value; }
    }
}
