using GroceryApp.DataAccess.Data;
using GroceryApp.Models;
using GroceryFinal.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GroceryFinal.DataAccess.Repository
{
    public class CustomerDetailsRepository : Repository<CustomerDetails>, ICustomerDetailsRepository
    {
        private ApplicationDbContext _db;
        public CustomerDetailsRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(CustomerDetails obj)
        {
            _db.CustomerDetailsTable.Update(obj);
        }
    }
}
