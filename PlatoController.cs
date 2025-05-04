using Microsoft.AspNetCore.Mvc;

namespace _2025_718_equipo1_tarea2;

[ApiController]
[Route("api/[controller]")]

public class PlatoController : Controller
{
    static private List<Plato> platos = new List<Plato>
    {
        new Plato
        {
            Id = 1,
            Nombre = "Pasta alfredo",
            Descripcion = "Pasta cubierta de salsa alfredo , queso mozzarrela y una suculenta salsa",
            Precio = 12,
            CategoriaId = 1,
            // Categoria = 



        }

    };
}