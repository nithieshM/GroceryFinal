using GroceryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryFinal.DataAccess.Repository.IRepository
{
    public interface ICustomerDetailsRepository : IRepository<CustomerDetails>
    {
        void Update(CustomerDetails obj);
        void Save();
    }
}
