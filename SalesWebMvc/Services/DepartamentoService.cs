using SalesWebMvc.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
    public class DepartamentoService
    {
        private readonly SalesWebMvcContext _context;
        public DepartamentoService(SalesWebMvcContext context)
        {
            _context = context;
        }
        public List<Departamento> FindAll()
        {
            return _context.Departamento.OrderBy(x => x.Nome).ToList();
        }
    }
}
