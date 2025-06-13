using EntitiesBL.ModelEntities.CommonBL;
using System.Reflection;
using AutoMapper;
using CommonBL.DTO;

namespace CommonBL
{
	public class MappingLogic<TEntity, TDTO>
		where TEntity : class, IDBCommon, new()
		where TDTO : class, IDTO, new()
	{
		public static List<TDTO> Map_Entity_To_DTO(List<TEntity> entitiesList)
		{
			var configuration = new MapperConfiguration(cfg =>
			{
				cfg.CreateMap<TEntity, TDTO>();
				cfg.AddMaps(Assembly.GetAssembly(typeof(TDTO)));
			});
			var mapper = configuration.CreateMapper();

			List<TDTO> responseList = mapper.Map<List<TEntity>, List<TDTO>>(entitiesList);
			long rowCount = 1;
			if (responseList != null && responseList.Count > 0)
				foreach (TDTO dto in responseList)
				{
					dto.RowCount = rowCount;
					rowCount++;
				}

			return responseList;
		}

		public static TDTO Map_Entity_To_DTO(TEntity entity)
		{
			TDTO response = new TDTO();

			var configuration = new MapperConfiguration(cfg =>
			{
				cfg.CreateMap<TEntity, TDTO>();
				cfg.AddMaps(Assembly.GetAssembly(typeof(TDTO)));
			});
			var mapper = configuration.CreateMapper();

			response = mapper.Map<TEntity, TDTO>(entity);

			return response;
		}

		public static TEntity Map_DTO_To_Entity(TDTO dto)
		{
			TEntity response = new TEntity();
			var configuration = new MapperConfiguration(cfg =>
			{
				cfg.CreateMap<TDTO, TEntity>();
				cfg.AddMaps(Assembly.GetAssembly(typeof(TEntity)));
			});
			var mapper = configuration.CreateMapper();
			response = mapper.Map<TDTO, TEntity>(dto);
			return response;
		}
	}
}
