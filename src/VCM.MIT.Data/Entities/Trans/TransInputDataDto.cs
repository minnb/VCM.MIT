using System;
using Abp.Application.Services.Dto;


namespace VCM.MIT.Data.Entities.Trans
{
    public class TransInputDataDto : FullAuditedEntityDto<Guid>
    {
		public new Guid? Id { get; set; }
		public string OrderNo { get; set; }
		public int LineNumber { get; set; }
		public string TableName { get; set; }
		public string DataType { get; set; }
		public string DataValue { get; set; }
	}
	public class TransInputDataViewDto
	{
		public TransInputDataDto TransInputDataDto { get; set; }
	}
	public class CreateTransInputDataDto : TransInputDataDto
	{

	}
	public class TransInputDataFilterDto : TransInputDataDto
	{
	}
}

