using OOP.CRUD.Entity.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.CRUD.DAL
{
    public class Repo : BaseRepo
    {
        public Repo()
        {
            _context = new OOP_CRUDContext();
            _productRepository = new ProductRepository(new OOP_CRUDContext());
        }
    }
}
