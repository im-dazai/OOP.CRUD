using OOP.CRUD.DAL.Interfaces;
using OOP.CRUD.Entity.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.CRUD.DAL
{
    public class ProductRepository : IProduct
    {
        private readonly OOP_CRUDContext _context;
        public ProductRepository(OOP_CRUDContext context)
        {
            _context = context;
        }

        public void Add(TblProduct product)
        {
            _context.TblProducts.Add(product);
            Save();
        }

        public void Delete(int id)
        {
           var user = _context.TblProducts.Where(x => x.Id == id).FirstOrDefault();
            _context.Remove(user);
            Save();
        }

        public List<TblProduct> GetAll()
        {
            var list = _context.TblProducts.ToList();
            return list;
        }

        public TblProduct GetByID(int id)
        {
            var product = _context.TblProducts.Where(x => x.Id == id).FirstOrDefault();
            return product;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(TblProduct product)
        {
           var result = _context.TblProducts.Where(x => x.Id == product.Id).FirstOrDefault();
            result.Name = product.Name;
            result.Category = product.Category;
            result.Id = product.Id;
            _context.Entry(result).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Save();
        }
    }
}
