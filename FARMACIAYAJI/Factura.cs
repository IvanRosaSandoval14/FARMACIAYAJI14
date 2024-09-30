using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FARMACIAYAJI
{
    public class Factura
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string NombreCliente { get; set; }
        public string CorreoCliente { get; set; }
        public decimal Total { get; set; }
    }
}
