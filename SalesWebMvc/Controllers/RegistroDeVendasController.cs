using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers
{
    public class RegistroDeVendasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PesquisaSimples()
        {
            return View();
        }

        public IActionResult PesquisaDeAgrupamento()
        {
            return View();
        }
    }
}
