using GroceryApp.DataAccess.Data;
using GroceryFinal.DataAccess.Repository.IRepository;
using GroceryFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryFinal.DataAccess.Repository
{
    public class UOMRepository : Repository<UOM>, IUOMRepository
    {
        private ApplicationDbContext _db;
        public UOMRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(UOM obj)
        {
            _db.UOMTable.Update(obj);
        }
    }
}
