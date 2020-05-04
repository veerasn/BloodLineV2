using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BloodLineV2.Models;

namespace BloodLineV2.Views.ProductInfo
{
    public class ProductInfoController : Controller
    {
        private readonly BBProductsEntities bbproduct = new BBProductsEntities();

        // GET: ProductInfo
        public ActionResult Index(string id)
        {
            var searchString = id;
            var products = (from p in bbproduct.Product_Info select p);

            products = products.Where(p => p.prod_bloodline.Contains(searchString));

            return View(products);
        }

        // GET: ProductInfo
        public ActionResult Tests(string id)
        {
            var searchString = id;
            var products = (from p in bbproduct.Product_Info select p);

            products = products.Where(p => p.prod_bloodline.Contains(searchString));

            return View(products);
        }


        // GET: ProductInfo
        public ActionResult Modifications(string id)
        {
            var searchString = id;
            var products = (from p in bbproduct.Modifications select p);

            products = products.Where(p => p.modification_code.Contains(searchString));
            ViewBag.Title = "Modifications - " + id;

            return View(products);
        }


        // GET: ProductInfo
        public ActionResult Guidelines_rbc()
        {
            return View();
        }

        // GET: ProductInfo
        public ActionResult Guidelines_plt()
        {
            return View();
        }

        // GET: ProductInfo
        public ActionResult Safe_transfusion()
        {
            return View();
        }

        // GET: ProductInfo
        public ActionResult Atr_fever()
        {
            return View();
        }
    }
}