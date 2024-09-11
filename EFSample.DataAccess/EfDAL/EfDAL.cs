using CW_Ef_Dbcontext.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace EFSample.DataAccess.EfDAL
{
    public class EfDAL : IEfDAL
    {
        private readonly BikeStoreContext _dbcontext;
        //private readonly IDbConnection _connection;
        public EfDAL(BikeStoreContext bikeStoreContext)
        {
            _dbcontext = bikeStoreContext;
            //_connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }

        public async Task<IEnumerable<Store>> GetStores()
        {
            return await _dbcontext.Stores.ToListAsync();
        }
    }
}
