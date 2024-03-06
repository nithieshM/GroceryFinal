using GroceryApp.DataAccess.Data;
using GroceryFinal.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryFinal.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public ICustomerDetailsRepository CustomerDetailsRepository { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            CustomerDetailsRepository = new CustomerDetailsRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
