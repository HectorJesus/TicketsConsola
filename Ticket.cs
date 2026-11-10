public enum PrioridadTicket
{
    Bajo = 1,
    Medio = 2,
    Alto = 3
}

public enum EstadoTicket
{
    Abierto = 1,
    EnProceso = 2,
    Cerrado = 3
}

public enum NivelTicket
{
    N1 = 1,
    N2 = 2,
}

public class Ticket
{
    public int Id {get; set;}
    public string Titulo {get; set;} ="";
    public string Descripcion {get; set;} ="";
    public int Prioridad {get; set;}
    public EstadoTicket Estado {get; set;}
    public DateTime Fechacreacion {get; set;} = DateTime.Now;
    public NivelTicket Nivel {get; set;}
}
