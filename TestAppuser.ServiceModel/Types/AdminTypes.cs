using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Auth;

namespace TestAppuser.ServiceModel.Types
{
    public class AppUser : UserAuth
    {
        #nullable enable
        public string? ProfileUrl { get; set; }
        public string? LastLoginIp { get; set; }
        public DateTime? LastLoginDate { get; set; }
        #nullable disable
        public int TenantsId { get; set; }
        
    }
}
