using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using Microsoft.EntityFrameworkCore;
using Sol.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Options;
using Sol.RelationalDb.Extensions;

namespace Sol.RelationalDb
{
    public class SolDb
    {
        protected const string SkipParam = "@skip";
        protected const string TakeParam = "@take";

        public SolDb(IOptions<SolDbSettings> solDbSettingsOptions)
        {
            Settings = solDbSettingsOptions.Value;
        }

        public SolDbSettings Settings { get; protected set; }

        protected string AppendOrderBy(string query, string column, bool asc)
        {
            string order = asc ? "ASC" : "DESC";
            return $"{query} ORDER BY {column} {order}";
        }

        protected string AppendFetchOffsetQuery(string query)
        {
            return $"{query} OFFSET {SkipParam} ROWS FETCH NEXT {TakeParam} ROWS ONLY";
        }

        public async  Task<IEnumerable<Tenant>> GetTenantsAsync(string orderBy = "CreatedUtc", bool isAsc = true, int? skip = 0, int? take = 0)
        {
            using (var conn = GetConnection())
            {
                string sql = "select Id, Name, RowVersion from dbo.Tenant";
                sql = AppendOrderBy(sql, orderBy, isAsc);
                sql = AppendFetchOffsetQuery(sql);
                return  await conn.QueryAsync<Tenant>(sql, new {skip, take});
            }
        }

        public IDbConnection GetConnection()
        {
            IDbConnection conn = new SqlConnection(Settings.ConnectionString);
            return conn;
        }
    }
}
