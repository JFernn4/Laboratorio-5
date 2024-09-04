using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5
{
    internal class Tarea
    {
        public int Numero {  get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }

        public Tarea(int numero, string nombre, string descripcion, bool estado)
        {
            Numero = numero;
            Nombre = nombre;
            Descripcion = descripcion;
            Estado = estado;
        }
    }
}
