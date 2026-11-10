while(true)
{
    Console.WriteLine("======== Ticket Administrador ========");
    Console.WriteLine("1. Crear Ticket");
    Console.WriteLine("2. Ver todos los tickets");
    Console.WriteLine("3. Filtrar por estado");
    Console.WriteLine("4. Cambiar estado de un ticket");
    Console.WriteLine("5. Reporte (Tickets por priopridad y por estado)");
    Console.WriteLine("0. Salir");

    int opc;
    opc = int.TryParse(Console.ReadLine(), out opc) ? opc : -1;
    switch(opc)
    {
        case 1:
            GestorTickets.CrearTicket();
            break;
        case 2:
            //GestorTickets.VerTickets();
            break;
        case 3:
            //GestorTickets.FiltrarTickets();
            break;
        case 4:
            //GestorTickets.CambiarEstado();
            break;
        case 5:
            //GestorTickets.Reporte();
            break;
        case 0:
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opción inválida. Intente nuevamente.");
            break;
    }
    break;
}