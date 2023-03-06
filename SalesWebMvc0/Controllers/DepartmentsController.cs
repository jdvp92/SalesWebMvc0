using Microsoft.AspNetCore.Mvc;
using SalesWebMvc0.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace SalesWebMvc0.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {

            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Electronics" });
            list.Add(new Department { Id = 2, Name = "Fashion" });

            return View(list);
        }
    }
}
