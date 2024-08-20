using OOP.CRUD.Entity.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.CRUD.DAL
{
    public class BaseRepo
    {
        protected ProductRepository _productRepository;
        protected OOP_CRUDContext _context;
    }
}
