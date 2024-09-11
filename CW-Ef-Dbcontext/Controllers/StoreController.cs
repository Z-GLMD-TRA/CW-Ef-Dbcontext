using CW_Ef_Dbcontext.Models;
using EFSample.DataAccess.EfDAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CW_Ef_Dbcontext.Controllers
{
    public class StoreController : Controller
    {
        private readonly IEfDAL _EfDAL;
        //private readonly BikeStoreContext _dbcontext;
        //private readonly IDbConnection _connection;
        //public StoreController(IConfiguration configuration,BikeStoreContext bikeStoreContext)
        //{
        //      _dbcontext = bikeStoreContext;
        //      _connection= new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        //}
        public StoreController(IEfDAL efDAL)
        {
            _EfDAL=efDAL;
        }
        public async Task<IActionResult> Index()
        {
            var storeList =await _EfDAL.GetStores();
            return View("StoreList", storeList);
        }
        //public async Task<IActionResult> GetById([FromRoute] int id)
        //{
        //    var store = await _dbcontext.Stores.FirstOrDefaultAsync(s => s.StoreId == id);
        //    return View("EditStore", store);
        //}
        //[HttpPost]
        //public async Task<IActionResult> Update([FromForm] Store store)
        //{
        //    var entity = _dbcontext.Stores.FirstOrDefault(item => item.StoreId == store.StoreId);

        //    // Validate entity is not null
        //    if (entity != null)
        //    {
        //        // Make changes on entity
        //        entity.StoreName = store.StoreName;
        //        entity.Phone = store.Phone;
        //        entity.Email = store.Email;
        //        entity.Street = store.Street;
        //        entity.City = store.City;
        //        entity.State = store.State;
        //        entity.ZipCode = store.ZipCode;
        //        // Save changes in database
        //        await _dbcontext.SaveChangesAsync();
        //    }

        //    return RedirectToAction("Index");
        //}
        //public async Task<IActionResult> Create()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public async Task<IActionResult> Create([FromForm] Store store)
        //{
        //    await _dbcontext.Stores.AddAsync(store);
        //    await _dbcontext.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}

        //public async Task<IActionResult> Delete([FromRoute] int id)
        //{
        //    var store = await _dbcontext.Stores.FirstOrDefaultAsync(s => s.StoreId == id);
        //    _dbcontext.Stores.Remove(store);
        //    await _dbcontext.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}
        //public async Task<IActionResult> Details([FromRoute] int id)
        //{
        //    Store store = await _dbcontext.Stores.Include(x => x.Staff).FirstOrDefaultAsync(s => s.StoreId == id);
        //    var staff = store.Staff;
        //    return View(staff);

        //}

    }
}
