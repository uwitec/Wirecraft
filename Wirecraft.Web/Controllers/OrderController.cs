﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wirecraft.Web.Logic;
using Wirecraft.Web.Models;

namespace Wirecraft.Web.Controllers
{
    public class OrderController : Controller
    {
        //
        // GET: /Order/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult updateProduct(int id, int productID, int quantity)
        {
            DataAccess da = new DataAccess();
            da.updateOrderProduct(id, productID, quantity);

            return Json(new { success = true });
        }

        [HttpPost]
        public ActionResult update(Order order)
        {
            DataAccess da = new DataAccess();
            da.updateOrder(order);

            return Json(new { success = true });
        }

    }
}