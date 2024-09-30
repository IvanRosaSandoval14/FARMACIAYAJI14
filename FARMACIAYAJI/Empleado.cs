using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace FARMACIAYAJI
{
    [Table("empleado")]
    public class Empleado
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }

        [Column("nombreCompleto")]
        public string NombreCompleto { get; set; }

        [Column("edad")]
        public int Edad { get; set; }

        [Column("dui")]
        public string DUI { get; set; }

        [Column("telefono")]
        public string Telefono { get; set; }

        [Column("residencia")]
        public string Residencia { get; set; }

        [Column("nivelEstudio")]
        public string NivelEstudio { get; set; }

        [Column("fechaContratacion")]
        public DateTime FechaContratacion { get; set; }
    }
}
