using System;
using System.Collections.Generic;


namespace SalesWebMvc.Models
{
    public class VendedorFormViewModel
    {
        public Vendedor Vendedor { get; set; }
        public ICollection<Departamento> Departamentos { get; set; }
    }
}
