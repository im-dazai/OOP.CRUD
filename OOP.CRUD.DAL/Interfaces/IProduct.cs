using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.CRUD.Entity.VM;

namespace OOP.CRUD.DAL.Interfaces
{
    public interface IProduct
    {
        void Add(TblProduct product);
        void Update(TblProduct product);
        TblProduct GetByID(int id);
        List<TblProduct> GetAll();
        void Delete(int id);
        void Save();
        
    }
}
