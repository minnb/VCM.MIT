using Abp.Auditing;
using System.ComponentModel.DataAnnotations;

namespace VCM.MIT.Web.Host.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [DisableAuditing]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
