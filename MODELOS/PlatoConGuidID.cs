namespace _2025_718_equipo1_tarea2;

public class PlatoConGuidID
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Nombre { get; set; }

    public string Descripcion { get; set; }

    public decimal Precio { get; set; }

    public int CategoriaId { get; set; }

    public int Categoria { get; set; }
}