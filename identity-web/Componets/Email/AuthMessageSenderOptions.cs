using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace identity_web.Componets.Email
{
    public class AuthMessageSenderOptions
    {
        /// <summary>
        /// 账号
        /// </summary>
        public string SendGridUser { get; set; }
        /// <summary>
        /// Key
        /// </summary>
        public string SendGridKey { get; set; }
    }
}
