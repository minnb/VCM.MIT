using Abp.Application.Services.Dto;

namespace VCM.MIT.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

