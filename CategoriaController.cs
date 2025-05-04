using Microsoft.AspNetCore.Mvc;

namespace _2025_718_equipo1_tarea2;


[ApiController]
[Route("api/[controller]")]
public class CategoriaController : Controller
{
  private static List<Categoria> categorias = new List<Categoria>
  {

    new Categoria
    {
      Id = Guid.NewGuid(),
      Nombre = "Pastas",
      //Platos =  {"Espaguetis", }
    },
    new Categoria
    {
    Id = Guid.NewGuid(),
    Nombre = "Sopas",
    //Platos =  {"Espaguetis", }
    },
    new Categoria
    {
    Id = Guid.NewGuid(),
    Nombre = "Mariscos",
    //Platos =  {"Espaguetis", }
  }
    

};
  
  
}