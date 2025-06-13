namespace EntitiesBL.ModelEntities.RepositoryBL
{
	public interface IUnitOfWork : IDisposable
	{
		int SaveChanges();
	}
}
