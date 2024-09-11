using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFSample.DataAccess.Models;   

namespace EFSample.DataAccess.EfDAL
{
    public interface IEfDAL
    {
        Task<IEnumerable<Store>> GetStores();
    }
}
