using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VCM.MIT.Data.Entities.Trans;

namespace VCM.MIT.Entities
{
    [AutoMap(typeof(TransRawViewDto))]
    [NotMapped]
    public class TransRawView
    {
        public TransRaw TransRaw { get; set; }
    }

    [AutoMap(typeof(TransRawDto))]
    [Table("M_TransRaw")]
    public class TransRaw : FullAuditedEntity<Guid>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [StringLength(10)]
        [Key]
        public string CompanyCode { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [StringLength(10)]
        [Key]
        public string AppCode { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [StringLength(6)]
        [Key]
        public string StoreNo { get; set; }
        [StringLength(12)]
        public string EntryDate { get; set; }
        [StringLength(MITConsts.OrderNoStringLength)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string TranNo { get; set; }
        [StringLength(3)]
        public string PosNo { get; set; }
        public DateTime DateInsert { get; set; }
        public string RawData { get; set; }
        [StringLength(1)]
        public string UpdateFlg { get; set; }
        [StringLength(16)]
        public string IPAddress { get; set; }
        [StringLength(25)]
        public string MACAddress { get; set; }
    }
}
