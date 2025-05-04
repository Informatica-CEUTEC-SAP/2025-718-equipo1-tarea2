using Microsoft.AspNetCore.Mvc;

namespace _2025_718_equipo1_tarea2;


[ApiController]
[Route("api/[controller]")]
public class PlatosController : ControllerBase
{
    private static List<PlatoConGuidID> platos = new List<PlatoConGuidID>
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
    };
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(platos);
    }
    [HttpGet("{id:guid}")]
    public IActionResult GetById(Guid id)
    {
        var plato = platos.FirstOrDefault(p => p.Id == id);
        if (plato == null) return NotFound();
        return Ok(plato);
    }
    [HttpPost]
    public IActionResult Create(PlatoConGuidID nuevoPlato)
    {
        nuevoPlato.Id = Guid.NewGuid(); // generar nuevo ID
        platos.Add(nuevoPlato);
        return CreatedAtAction(nameof(GetById), new { id = nuevoPlato.Id }, nuevoPlato);
    }
    [HttpPut("{id:guid}")]
    public IActionResult Update(Guid id, PlatoConGuidID actualizado)
    {
        var plato = platos.FirstOrDefault(p => p.Id == id);
        if (plato == null) return NotFound();

        plato.Nombre = actualizado.Nombre;
        plato.Descripcion = actualizado.Descripcion;
        plato.Precio = actualizado.Precio;
        plato.CategoriaId = actualizado.CategoriaId;

        return NoContent();
    }
    [HttpDelete("{id:guid}")]
    public IActionResult Delete(Guid id)
    {
        var plato = platos.FirstOrDefault(p => p.Id == id);
        if (plato == null) return NotFound();

        platos.Remove(plato);
        return NoContent();
    }
}
