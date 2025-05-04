using Microsoft.AspNetCore.Mvc;

namespace _2025_718_equipo1_tarea2;

[ApiController]
[Route("api/[controller]")]
public class CategoriaController : ControllerBase
{
    private static List<Categoria> categorias = new List<Categoria>
    {
        new Categoria
        {
            Id = Guid.NewGuid(),
            Nombre = "Pastas",
            Platos = new List<PlatoConGuidID> // Asocias platos a la categoría
            {
                new PlatoConGuidID
                {
                    Id = Guid.NewGuid(),
                    Nombre = "Pasta Alfredo",
                    Descripcion = "Pasta cubierta de salsa alfredo, queso mozzarella y una suculenta salsa",
                    Precio = 12,
                    CategoriaId = 1
                },
                new PlatoConGuidID
                {
                    Id = Guid.NewGuid(),
                    Nombre = "Espaguetis",
                    Descripcion = "Pasta cubierta de salsa roja de tomate",
                    Precio = 15,
                    CategoriaId = 1
                }
            }
        },
        new Categoria
        {
            Id = Guid.NewGuid(),
            Nombre = "Sopas",
            Platos = new List<PlatoConGuidID> // Asocias platos a la categoría
            {
                new PlatoConGuidID
                {
                    Id = Guid.NewGuid(),
                    Nombre = "Sopa de Pollo",
                    Descripcion = "Sopa caliente de pollo con verduras frescas",
                    Precio = 8,
                    CategoriaId = 2
                }
            }
        },
        new Categoria
        {
            Id = Guid.NewGuid(),
            Nombre = "Mariscos",
            Platos = new List<PlatoConGuidID> // Asocias platos a la categoría
            {
                new PlatoConGuidID
                {
                    Id = Guid.NewGuid(),
                    Nombre = "Paella de Mariscos",
                    Descripcion = "Arroz con mariscos frescos, tomate y azafrán",
                    Precio = 20,
                    CategoriaId = 3
                }
            }
        }
    };

    
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(categorias);
    }

    
    [HttpPost]
    public IActionResult Create([FromBody] Categoria nuevaCategoria)
    {
        nuevaCategoria.Id = Guid.NewGuid(); // Generar un nuevo ID para la categoría
        categorias.Add(nuevaCategoria);
        return CreatedAtAction(nameof(GetAll), nuevaCategoria);
    }
}
