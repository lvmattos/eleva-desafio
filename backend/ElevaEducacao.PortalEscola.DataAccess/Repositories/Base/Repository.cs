using Dapper;
using ElevaEducacao.PortalEscola.Application.Infrastructure;
using ElevaEducacao.PortalEscola.Application.Util;
using ElevaEducacao.PortalEscola.Common;
using ElevaEducacao.PortalEscola.Domain.Entities.Base;
using ElevaEducacao.PortalEscola.Domain.Repositories.Base;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ElevaEducacao.PortalEscola.DataAccess.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly IConfiguration _configuration;
        private readonly IApplicationLogger _applicationLogger;

        public Repository(
            IConfiguration configuration,
            IApplicationLogger applicationLogger)
        {
            Guardian.AgainstNull(configuration);
            Guardian.AgainstNull(applicationLogger);

            _configuration = configuration;
            _applicationLogger = applicationLogger;
        }

        private SqlConnection OpenDbConnection()
        {
            return new SqlConnection(_configuration[Constants.ConnectionString]);
        }

        public async Task AddAsync(T entity, string query)
        {
            using (var sqlConnection = OpenDbConnection())
            {
                try
                {
                    await sqlConnection.OpenAsync();
                    await sqlConnection.ExecuteAsync(query, entity);
                }
                catch (Exception exception)
                {
                    _applicationLogger.LogError(exception, exception.Message);
                    throw exception;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        public async Task<IEnumerable<T>> FindAllAsync(string query)
        {
            using (var sqlConnection = OpenDbConnection())
            {
                try
                {
                    await sqlConnection.OpenAsync();
                    return (await sqlConnection.QueryAsync<T>(query)).ToList();
                }
                catch (Exception exception)
                {
                    _applicationLogger.LogError(exception, exception.Message);
                    throw exception;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        public async Task<IEnumerable<Z>> QueryAllAsync<Z>(string query)
        {
            using (var sqlConnection = OpenDbConnection())
            {
                try
                {
                    await sqlConnection.OpenAsync();
                    return (await sqlConnection.QueryAsync<Z>(
                        query)).ToList();
                }
                catch (Exception exception)
                {
                    _applicationLogger.LogError(exception, exception.Message);
                    throw exception;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
