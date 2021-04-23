using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCM.MIT.Models.User
{
    public class UserProfile
    {
        public string StaffCode { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string CompanyCode { get; set; }
        public string DivisionCode { get; set; }
        public string ProvinceCode { get; set; }
        public string HubCode { get; set; }
        public string DeliveryAddress { get; set; }
        public string DepartmentCode { get; set; }
        public bool Blocked { get; set; }
        public string Avata { get; set; }
    }
    public class UserInToken : UserProfile
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
    }
}
