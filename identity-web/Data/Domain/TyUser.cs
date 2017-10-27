using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace identity_web.Data.Domain
{
    /// <summary>
    /// 用户
    /// </summary>
    [Table("TyUser")]
    public class TyUser : IdentityUser<string>
    {
    }
}
