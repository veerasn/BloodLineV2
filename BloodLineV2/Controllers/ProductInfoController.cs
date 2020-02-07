﻿using System;
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
        public ActionResult Index()
        {
            var searchString = "RCWB";
            var products = (from p in bbproduct.Product_Info select p);

            products = products.Where(p => p.prod_bloodline.Contains(searchString));

            return View(products);
        }
    }
}