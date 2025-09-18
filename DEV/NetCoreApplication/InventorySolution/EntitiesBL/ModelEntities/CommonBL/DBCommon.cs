using EntitiesBL.ModelEntities.GeneratedEnitities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EntitiesBL.ModelEntities.CommonBL
{
    public class DBCommon
    {
        //public static async Task<List<TEntity>> GetFromStoreProcedures<TEntity>(InventoryDbContext context)
        //    where TEntity : class, IDBCommon
        //{
        //    FormattableString storedProcName = $"TEntity";
        //    var result = await _context.Database.SqlQuery<GetInventoryStores>($"GetInventoryStores {inventoryStoreID}").ToListAsync();
        //    return list;
        //}

        //public static async Task<List<TEntity>> ExecuteStoredProcedureAsync<TEntity>(InventoryDbContext context, string storedProcedureName, params object[] parameters)
        //    where TEntity : class, IDBCommon
        //{
        //    //FormattableString sql = BuildSqlWithParameters(storedProcedureName, parameters.Length);
        //    FormattableString sql = $"{storedProcedureName} {parameters[0]}";
        //    return await context.Database.SqlQuery<TEntity>(sql).ToListAsync();
        //}

        public static async Task<List<TEntity>> ExecuteStoredProcedureAsync<TEntity>(InventoryDbContext context, string procedureName, Dictionary<string, object> parameters)
            where TEntity : class
        {
            // Build SQL like: EXEC GetInventoryStores @param1, @param2
            var sql = $"EXEC {procedureName} " +
                      string.Join(", ", parameters.Keys.Select(k => $"@{k}"));

            // Convert to SqlParameter[]
            var sqlParams = parameters
                .Select(p => new SqlParameter($"@{p.Key}", p.Value ?? DBNull.Value))
                .ToArray();

            // Execute stored procedure using FromSqlRaw
            return await context.Set<TEntity>()
                .FromSqlRaw(sql, sqlParams)
                .ToListAsync();
        }

        private static FormattableString BuildSqlWithParameters(string storedProcedure, int parameterCount)
        {
            if (parameterCount == 0)
                return $"EXEC {storedProcedure}";

            string placeholders = string.Join(", ", Enumerable.Range(0, parameterCount).Select(i => $"{{{i}}}"));
            return $"EXEC {storedProcedure} {placeholders}";
        }
    }
}
