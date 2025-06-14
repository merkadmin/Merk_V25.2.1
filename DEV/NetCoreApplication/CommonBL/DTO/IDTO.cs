using EntitiesBL.ModelEntities.CommonBL;

namespace CommonBL.DTO
{
	public interface IDTO
	{
		long ID { get; set; }
		bool IsOnDuty { get; set; }
		long UserID { get; set; }
		long RowCount { get; set; }
		DateTime InsertedDate { get; set; }
	}
}
