using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using OOP.CRUD.DAL;
using OOP.CRUD.Entity.VM;

namespace OOP.CRUD.Controllers
{
    public class BaseController : Controller
    {
        protected Repo _repo;
        protected ProductRepository _productRepository;

        protected void InitRepo()
        {
            this._repo = new Repo();
            this._productRepository = new ProductRepository(new OOP_CRUDContext());
            
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
            InitRepo();
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
