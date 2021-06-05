using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using System;
using Abp.Linq.Extensions;
using System.Linq;
using System.Threading.Tasks;
using VCM.MIT.Data.Entities.Trans;
using VCM.MIT.Entities;
using VCM.MIT.VCM.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace VCM.MIT.VCM.Implementation
{
    public class TransRawAppService : AsyncCrudAppService<TransRaw, TransRawDto, Guid, TransRawFilterDto, TransRawDto, TransRawDto>, ITransRawAppService
    {
        private readonly IRepository<TransRaw, Guid> _transRawRepository;
        public TransRawAppService(IRepository<TransRaw, Guid> repository)
         : base(repository)
        {
            _transRawRepository = repository;
        }
        protected override IQueryable<TransRaw> CreateFilteredQuery(TransRawFilterDto input)
        {
            return base.CreateFilteredQuery(input)
                        //.WhereIf(!string.IsNullOrEmpty(input.Id.ToString()), t => t.Id == input.Id)
                        //.WhereIf(!string.IsNullOrEmpty(input.EntryDate.ToString()), t => t.EntryDate == input.EntryDate)
                        //.WhereIf(!string.IsNullOrEmpty(input.TranNo), t => t.TranNo == input.TranNo)
                        //.WhereIf(!string.IsNullOrEmpty(input.CompanyCode), t => t.CompanyCode == input.CompanyCode)
                        //.WhereIf(!string.IsNullOrEmpty(input.AppCode), t => t.AppCode == input.AppCode)
                        .WhereIf(!string.IsNullOrEmpty(input.UpdateFlg), t => t.UpdateFlg == input.UpdateFlg);
        }
        private IQueryable<TransRawView> CreateFilterQueryView(TransRawFilterDto filter)
        {
            var dataQuery = CreateFilteredQuery(filter);
            return from TransRaw in dataQuery
                                select new TransRawView
                                {
                                    TransRaw = TransRaw
                                };
        }

        public async Task<PagedResultDto<TransRawViewDto>> GetAllView(TransRawFilterDto filter)
        {
            var dataViewQuery = CreateFilterQueryView(filter);
            var dataView = await dataViewQuery.ToListAsync();
            var dataViewDto = ObjectMapper.Map<List<TransRawViewDto>>(dataView);
            return new PagedResultDto<TransRawViewDto>(dataViewDto.Count, dataViewDto);
        }

        public override async Task<TransRawDto> UpdateAsync(TransRawDto input)
        {
            if(input.UpdateFlg == "N")
            {
                input.UpdateFlg = "Y";
            }
            return await base.UpdateAsync(input);
        }

        public async Task<List<TransRaw>> GetTransRawN(string updateFlg)
        {
            return await  _transRawRepository.GetAll().Where(x => x.UpdateFlg == updateFlg).ToListAsync();
        }

        public bool UpdateFlgTransRaw(Guid id, string updateFlg)
        {
            try
            {
                _transRawRepository.Update(id, x => x.UpdateFlg = updateFlg);
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
