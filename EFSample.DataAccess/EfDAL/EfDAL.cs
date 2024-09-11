using EFSample.DataAccess.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace EFSample.DataAccess.EfDAL
{
    public class EfDAL : IEfDAL
    {
        private readonly BikeStoreContext _dbcontext;

        public EfDAL(BikeStoreContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<IEnumerable<Store>> GetStores()
        {
            
            return await _dbcontext.Stores.ToListAsync();
        }
    }
}
