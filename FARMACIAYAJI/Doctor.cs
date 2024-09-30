using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FARMACIAYAJI
{
    public class Doctor
    {
        public string NombreCompleto { get; set; }
        public int Edad { get; set; }
        public string Especialidad { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string LugarAtencion { get; set; }
        public string HorarioAtencion { get; set; }
        public string Foto { get; set; } // La imagen puede ser un recurso local o una URL
    }
}
