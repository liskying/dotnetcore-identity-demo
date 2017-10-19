using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace identity_web.Data.Domain
{
    /// <summary>
    /// 角色
    /// </summary>
    [Table("TyRole")]
    public class TyRole : IdentityRole<string>
    {
    }
}
