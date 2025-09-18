using System;

namespace EntitiesBL.EntitiesCommonBL.EntitiesLogicLayer.UnitOfWork
{
	public interface IUnitOfWork : IDisposable
	{
		int SaveChanges();
	}
}
