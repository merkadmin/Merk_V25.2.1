using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace EntitiesBL.ModelEntities.CommonBL
{
    public static class DbContextExtensions
    {
        public static async Task<List<TEntity>> ExecuteStoredProcedureAsync<TEntity>(this DbContext context, string procedureName, Dictionary<string, object> parameters)
            where TEntity : class
        {
            var sql = $"EXEC {procedureName} " + string.Join(", ", parameters.Keys.Select(k => $"@{k}"));

            var sqlParams = parameters.Select(p => new SqlParameter($"@{p.Key}", p.Value ?? DBNull.Value)).ToArray();

            return await context.Set<TEntity>().FromSqlRaw(sql, sqlParams).ToListAsync();
        }
    }
}
