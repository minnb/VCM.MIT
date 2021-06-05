using Abp.BackgroundJobs;
using Abp.Dependency;
using Abp.Domain.Uow;
using Castle.Core.Logging;
using VCM.MIT.AppService.Trans;
using VCM.MIT.Data.Entities.Trans;

namespace VCM.MIT.BackgroundJob
{
    public class TransactionsJob: BackgroundJob<TransRawDto>, ITransientDependency
    {
        private readonly ILogger _logger;
        private readonly ITransService _transService;
        public TransactionsJob(
            ILogger logger,
            ITransService transService
            )
        {
            _logger = logger;
            _transService = transService;
        }


        [UnitOfWork]
        public override void Execute(TransRawDto args)
        {
            _logger.Warn("====>>> START BackgroundJob TransactionsJob");
            
        }
    }
}
