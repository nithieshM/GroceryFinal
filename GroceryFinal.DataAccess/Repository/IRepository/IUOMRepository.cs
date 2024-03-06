using GroceryFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryFinal.DataAccess.Repository.IRepository
{
    public interface IUOMRepository:IRepository<UOM>
    {
        void Update(UOM obj);
    }
}
