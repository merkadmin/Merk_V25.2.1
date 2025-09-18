using System;
using AutoMapper;
using AutoMapper.Configuration.Annotations;
using AutoMapper.Configuration.Conventions;
using EntitiesBL;
using EntitiesBL.EntitiesCommonBL;

namespace CommonBL.DTO
{
	[AutoMap(typeof(InventoryCategory_cu))]
	public class InventoryCategory_DTO : IDTO
	{
		#region Implementation of IDTO

		public long ID { get; set; }
		public bool IsOnDuty { get; set; }

		[SourceMember(nameof(InventoryCategory_cu.InsertedBy))]
		[MapTo("InsertedBy")]
		public long UserID { get; set; }

		public long RowCount { get; set; }

		[SourceMember(nameof(InventoryCategory_cu.InsertedDate))]
		[MapTo("InsertedDate")]
		public DateTime InsertedDate { get; set; }

		public DB_CommonTransactionType DB_CommonTransactionType { get; set; }

		#endregion

		[SourceMember(nameof(InventoryCategory_cu.Name_P))]
		[MapTo("Name_P")]
		public string CategoryName_P { get; set; }

		[SourceMember(nameof(InventoryCategory_cu.Name_S))]
		[MapTo("Name_S")]
		public string CategoryName_S { get; set; }

		[SourceMember(nameof(InventoryCategory_cu.InternalCode))]
		[MapTo("InternalCode")]
		public string CategoryInternalCode { get; set; }
	}
}
