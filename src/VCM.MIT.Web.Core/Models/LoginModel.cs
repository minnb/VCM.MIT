using Abp.Auditing;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VCM.MIT.Models.Trans
{
    public class LoginModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [DisableAuditing]
        public string Password { get; set; }
        [DefaultValue(false)]
        public bool RememberMe { get; set; }
    }
}
