using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace identity_web.Data.Domain
{
    /// <summary>
    /// 角色声明
    /// </summary>
    [Table("TyRoleClaim")]
    public class TyRoleClaim : IdentityRoleClaim<string>
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
