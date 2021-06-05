using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCM.MIT.Data.Entities.Trans;

namespace VCM.MIT.Entities.Trans
{
    [AutoMap(typeof(TransInfocodeEntryViewDto))]
    [NotMapped]
    public class TransInfoCodeEntryView
	{
        public TransInfoCodeEntry TransInfoCodeEntry { get; set; }
    }

    [AutoMap(typeof(TransInfoCodeEntryDto))]
    [Table("M_TransInfoCodeEntry")]
    public class TransInfoCodeEntry : FullAuditedEntity<Guid>
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public override Guid Id { get; set; }

		[StringLength(MITConsts.OrderNoStringLength)]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Key]
		public string OrderNo { get; set; }
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Key]
		public int LineNo_ { get; set; }
		public int OrderLineNo { get; set; }
		public int TransactionType { get; set; }
		[StringLength(MITConsts.OrderNoStringLength)]
		public string Infocode { get; set; }
		[StringLength(100)]
		public string Infomation { get; set; }
		public int TypeOfInput { get; set; }
		public int TextType { get; set; }
		[StringLength(18)]
		public string ItemNo { get; set; }
		[StringLength(100)]
		public string SourceCode { get; set; }
		public decimal Amount { get; set; }
		[StringLength(100)]
		public string SubCode { get; set; }
		public int ParentLineNo { get; set; }
		[StringLength(1000)]
		public string Options { get; set; }
	}
}
