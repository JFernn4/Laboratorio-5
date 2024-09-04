using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5
{
    internal class GestionTareas
    {
        List<Tarea> listaTareas=new List<Tarea>();
        public void RegistrarTarea()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------");
            Console.WriteLine("REGISTRAR TAREA");
            Console.WriteLine("---------------");
            Console.ResetColor();
            Console.Write("o Número: ");
            int numero= Convert.ToInt32(Console.ReadLine());
            Console.Write("o Nombre: ");
            string nombre= Console.ReadLine();
            Console.Write("o Descripción: ");
            string descripcion= Console.ReadLine();
            bool estado = false;
            Tarea tarea= new Tarea(numero,nombre,descripcion,estado);
            listaTareas.Add(tarea);
            Console.WriteLine("Se ha registrado la tarea.");
            Console.ReadKey();
        }
        public void MostrarTareas()
        {
            Console.Clear();
            string tareaCompletada=string.Empty;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("------");
            Console.WriteLine("TAREAS");
            Console.WriteLine("------");
            Console.ResetColor();
            foreach (Tarea tarea in listaTareas)
            {
                if (tarea.Estado == false)
                {
                    tareaCompletada = "Pendiente";
                }
                else if (tarea.Estado == true)
                {
                    tareaCompletada = "Completada";
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("o ");
                Console.ResetColor();
                Console.WriteLine($"Tarea número {tarea.Numero}");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"{tarea.Nombre}");
                Console.ResetColor();
                Console.WriteLine($"{tarea.Descripcion}");
                Console.WriteLine($"Estado: {tareaCompletada}");
            }
            Console.ReadKey();
        }
        public void MarcarComoCompletada()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------------------------");
            Console.WriteLine("MARCAR TAREA COMO COMPLETADA");
            Console.WriteLine("----------------------------");
            Console.ResetColor();
            Console.WriteLine("o Ingresa el nombre de la tarea que completaste.");
            int numeroTarea= Convert.ToInt32(Console.ReadLine());
            Tarea buscar = listaTareas.Find(p => p.Numero == numeroTarea);
            if ( buscar != null )
            {
                buscar.Estado = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Se ha marcado como completada.");
                Console.ResetColor();
                Console.ReadKey();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No se ha encontrado la tarea.");
                Console.ResetColor();
                Console.ReadKey();
            }
        }
    }
}
