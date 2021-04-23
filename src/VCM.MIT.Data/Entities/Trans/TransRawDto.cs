using Abp.Domain.Entities.Auditing;
using System;

namespace VCM.MIT.Data.Entities.Trans
{
    public class TransRawDto : FullAuditedEntity<Guid>
    {
        public string CompanyCode { get; set; }
        public string AppCode { get; set; }
        public string StoreCode { get; set; }
        public string EntryDate { get; set; }
        public string TranNo { get; set; }
        public string PosNo { get; set; }
        public DateTime DateInsert { get; set; }
        public string RawData { get; set; }
        public string UpdateFlg { get; set; }
        public string IPAddress { get; set; }
        public string MACAddress { get; set; }
    }
    public class TransRawViewDto
    {
        public TransRawDto TransRawDto { get; set; }
    }
    public class TransRawFilterDto : TransRawDto
    {
    }
}
