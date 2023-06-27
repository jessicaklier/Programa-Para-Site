using SalesWebMvc.Models.Enums;
using System;


namespace SalesWebMvc.Models
{
    public class RegistroDeVenda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Quantia { get; set; }
        public StatusDeVenda Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public RegistroDeVenda()
        {

        }

        public RegistroDeVenda(int id, DateTime data, double quantia, StatusDeVenda status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Quantia = quantia;
            Status = status;
            Vendedor = vendedor;
            
        }

    }
}
