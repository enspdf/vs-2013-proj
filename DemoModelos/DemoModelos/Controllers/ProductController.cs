using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoModelos.Controllers
{
    public class ProductController : Controller
    {

        public ActionResult Index()
        {
            var Repository = new ModelCL.Repository();
            var Model = Repository.GetProducts();
            return View(Model);
        }

        // GET: Product
        public ActionResult Details(int id)
        {
            ActionResult Result = null;
            var Repository = new ModelCL.Repository();
            var Model = Repository.GetProductByID(id);

            if (Model != null)
            {
                Result = View("Details", Model);
            }
            else
            {
                Result = Content("Producto no encontrado");
            }
            return Result;
        }
    }
}