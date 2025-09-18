using System;
using EntitiesBL.EntitiesCommonBL;

namespace EntitiesBL
{
	public partial class InventoryCategory_cu : IDBCommon
	{
		public long EntityID => ID;
		public DB_CommonTransactionType DBCommonTransactionType { get; set; }
		long IDBCommon.InsertedBy { get; set; }
		DateTime IDBCommon.InsertedDate { get; set; }
	}
}
