namespace EntitiesBL.ModelEntities.CommonBL
{
	public interface IDBCommon
	{
		long EntityID { get; }
		bool IsOnDuty { get; set; }
		long InsertedBy { get; set; }
		DateTime InsertedDate { get; set; }
		DB_CommonTransactionType DBCommonTransactionType { get; set; }
	}
}
