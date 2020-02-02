using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoParcialBeta.Data
{
    public class Prestamos
    {
        [Key]
        public int PrestamoId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public int Semanas { get; set; }
        public string Concepto { get; set; }

        public Prestamos()
        {
            PrestamoId = 0;
            Fecha = DateTime.Now;
            Monto = 0;
            Semanas = 0;
            Concepto = String.Empty;
        }
    }
}
