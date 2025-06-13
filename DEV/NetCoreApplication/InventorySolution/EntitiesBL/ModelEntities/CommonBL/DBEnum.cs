namespace EntitiesBL.ModelEntities.CommonBL
{
	#region DBCommon

	public enum DB_CommonTransactionType
	{
		None = 0,
		CreateNew = 1,
		SaveNew = 2,
		UpdateExisting = 3,
		DeleteExisting = 4,
		Load = 5,
		SearchReport = 6
	}
	public enum DBCommonEntitiesType
	{
		CustomUserEntities = 1,
		BridgeEntities = 2,
		TransactionsEntities = 3,
		PrivateInternalEntities = 4,
		ConfigurationEntities = 5
	}

	#endregion
}
