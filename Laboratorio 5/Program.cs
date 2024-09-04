int opcion;
bool menu = true;
while (menu)
{
    MostrarMenu();
    opcion= Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            {
                break;
            }
        case 2:
            {
                break;
            }
        case 3:
            {
                break;
            }
        case 4:
            {
                break;
            }
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