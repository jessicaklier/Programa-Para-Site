using Microsoft.AspNetCore.Mvc;
using System;
using SalesWebMvc.Models;
using System.Collections.Generic;


namespace SalesWebMvc.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> list = new List<Departamento>();
            list.Add(new Departamento { Indice = 1, Nome = "Eletronicos" });
            list.Add(new Departamento { Indice = 2, Nome = "Moda" });

            return View(list);
        }
    }
}
