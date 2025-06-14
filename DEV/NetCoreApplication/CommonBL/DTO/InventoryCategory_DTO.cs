using AutoMapper.Configuration.Annotations;
using EntitiesBL.ModelEntities.GeneratedEnitities;

namespace CommonBL.DTO
{
	public class InventoryCategory_DTO : IDTO
	{
		#region Implementation of IDTO

		public long ID { get; set; }
		public bool IsOnDuty { get; set; }
		public long UserID { get; set; }
		public long RowCount { get; set; }
		public DateTime InsertedDate { get; set; }

		#endregion

		[SourceMember(nameof(InventoryStoreCu.NameP))]
		public string Name_en { get; set; }
		public string Name_ar { get; set; }
	}
}
