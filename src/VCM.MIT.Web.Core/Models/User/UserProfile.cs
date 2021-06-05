using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCM.MIT.Models.User
{
    public class UserProfile
    {
        public string CompanyCode { get; set; }
        public string AppCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
    public class UserInToken : UserProfile
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
    }
}
