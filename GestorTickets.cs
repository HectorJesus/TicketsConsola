public static class GestorTickets
{
    public static  Ticket CrearTicket()
    {
        var ticket = new Ticket();

        Console.WriteLine("Titulo:");
        ticket.Titulo = Console.ReadLine() ?? "";
        Console.WriteLine("Descripcion:");
        ticket.Descripcion = Console.ReadLine() ?? "";
        
        Console.WriteLine("Prioridad (1-Bajo, 2-Medio, 3-Alto):");
        int.TryParse(Console.ReadLine(), out int prioridad);
        ticket.Prioridad = prioridad;
        while (true)
        {
            Console.WriteLine("Nivel (1-N1, 2-N2):");
            if(int.TryParse(Console.ReadLine(), out int n) && Enum.IsDefined(typeof(NivelTicket), n))
            {
                ticket.Nivel = (NivelTicket)n;
                break;
            }
            Console.WriteLine("Nivel inválido. Intente nuevamente.");
        }

        return ticket;
    }
}