using Laboratorio_5;

int opcion;
bool menu = true;
GestionTareas gestionTareas = new GestionTareas();
while (menu)
{
    try
    {
        MostrarMenu();
        opcion = Convert.ToInt32(Console.ReadLine());
        if (opcion > 4 || opcion < 1)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Debes ingresar un número del 1 al 4.");
            Console.ResetColor();
            Console.ReadKey();
        }
        else
        {
            switch (opcion)
            {
                case 1:
                    {
                        gestionTareas.RegistrarTarea();
                        break;
                    }
                case 2:
                    {
                        gestionTareas.MostrarTareas();
                        break;
                    }
                case 3:
                    {
                        gestionTareas.MarcarComoCompletada();
                        break;
                    }
                case 4:
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("-------------------");
                        Console.WriteLine("PROGRAMA FINALIZADO");
                        Console.WriteLine("-------------------");
                        Console.ResetColor ();
                        Console.ReadKey();
                        menu = false;
                        break;
                    }
            }
        }
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Debes ingresar un número del 1 al 4.");
        Console.ResetColor();
        Console.ReadKey();
    }

}
static void MostrarMenu()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("----------------------------");
    Console.WriteLine("SISTEMA DE GESTIÓN DE TAREAS");
    Console.WriteLine("----------------------------");
    Console.ResetColor();
    Console.WriteLine("(1) Añadir tarea.");
    Console.WriteLine("(2) Ver todas las tareas.");
    Console.WriteLine("(3) Marcar tarea como completada.");
    Console.WriteLine("(4) Salir.");
}