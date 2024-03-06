using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryFinal.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICustomerDetailsRepository CustomerDetailsRepository { get; }
        ISupplierRepository SupplierRepository { get; }
        IProductRepository ProductRepository { get; }

        void Save();
    }
}
