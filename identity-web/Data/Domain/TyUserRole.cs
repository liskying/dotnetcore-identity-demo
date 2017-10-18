using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace identity_web.Data.Domain
{
    /// <summary>
    /// 用户角色对应表
    /// </summary>
    [Table("TyUserRole")]
    public class TyUserRole : IdentityUserRole<string>
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; }
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
