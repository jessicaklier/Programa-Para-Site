using SalesWebMvc.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using SalesWebMvc.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class DepartamentoService
    {
        private readonly SalesWebMvcContext _context;
        public DepartamentoService(SalesWebMvcContext context)
        {
            _context = context;
        }
        public async Task<List<Departamento>> FindAllAsync()
        {
            return await _context.Departamento.OrderBy(x => x.Nome).ToListAsync();
        }
    }
}
