namespace _2025_718_equipo1_tarea2;

public class Categoria
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Nombre { get; set; }

    public List<PlatoConGuidID> Platos { get; set; }
}