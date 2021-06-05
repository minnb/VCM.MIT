using System.Collections.Generic;
using System.Threading.Tasks;
using VCM.MIT.Data.Entities.Trans;
using VCM.MIT.Models.Trans;
using VCM.MIT.Models.User;

namespace VCM.MIT.AppService.Trans
{
    public interface ITransService
    {
        Task<string> CreateTransRawAsync(UserInToken userInfo, TransHeaderModel input);
        Task<string> CreateTransRawMasterAsync(UserInToken userInfo, TransRawModel input);
        Task<string> CreateTransHeader(TransHeaderModel input);
        Task<bool> CreateTransLine(string storeNo, string posNo, string orderNo, List<TransLineModel> input);
        Task<bool> CreateTransPaymentEntry(string storeNo, string posNo, string orderNo, List<TransPaymentEntryModel> input);
        Task<bool> CreateTransDiscountEntry(string orderNo, string itemNo, int lineNo, List<TransDiscountEntryModel> input);
    }
}
