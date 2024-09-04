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
            try
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("---------------");
                Console.WriteLine("REGISTRAR TAREA");
                Console.WriteLine("---------------");
                Console.ResetColor();
                Console.Write("o Número: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                Tarea numeroExistente = listaTareas.Find(p => p.Numero == numero);
                if (numeroExistente == null)
                {
                    Console.Write("o Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("o Descripción: ");
                    string descripcion = Console.ReadLine();
                    bool estado = false;
                    Tarea tarea = new Tarea(numero, nombre, descripcion, estado);
                    listaTareas.Add(tarea);
                    Console.WriteLine("Se ha registrado la tarea.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ya existe una tarea con ese número.");
                    Console.ResetColor();
                }
                Console.ReadKey();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Debes ingresar un número válido.");
                Console.ResetColor();
                Console.ReadKey();
            }
        }
        public void MostrarTareas()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("------");
            Console.WriteLine("TAREAS");
            Console.WriteLine("------");
            Console.ResetColor();
            if (listaTareas.Count > 0)
            {
                string tareaCompletada = string.Empty;
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
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{tarea.Nombre}");
                    Console.ResetColor();
                    Console.WriteLine($"{tarea.Descripcion}");
                    Console.WriteLine($"Estado: {tareaCompletada}");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No existen tareas registradas.");
                Console.ResetColor();
            }
            Console.ReadKey();
        }
        public void MarcarComoCompletada()
        {
            try
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("----------------------------");
                Console.WriteLine("MARCAR TAREA COMO COMPLETADA");
                Console.WriteLine("----------------------------");
                Console.ResetColor();
                foreach (Tarea tarea in listaTareas)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("o ");
                    Console.ResetColor();
                    Console.WriteLine($"{tarea.Numero}. {tarea.Nombre}.");
                }
                Console.WriteLine("o Ingresa el número de la tarea que completaste.");
                int numeroTarea = Convert.ToInt32(Console.ReadLine());
                Tarea buscar = listaTareas.Find(p => p.Numero == numeroTarea);
                if (buscar != null)
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
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Debes ingresar un número válido.");
                Console.ResetColor();
                Console.ReadKey();
            }
        }
    }
}
