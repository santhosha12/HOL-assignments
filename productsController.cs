﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HOL2.Controllers
{
    public class productsController : Controller
    {
        // GET: products
        public ActionResult Index()
        {
            Models.Product p = new Models.Product();
            //pass a list of products to the view
            return View(p.GetProducts());
           
        }
    }
}