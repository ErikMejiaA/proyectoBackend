using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class ProductoController : BaseApiController
{
    //creamos el constructor de la clase 
    private readonly ProyectoBackendContext _context;
    
    public ProductoController(ProyectoBackendContext context)
    {
       _context = context;
    }

    //Metodo GET para traer todos los registro de la entidad Producto de la Db
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Producto>>> Get()
    {
         var productos = await _context.Productos.ToListAsync();
         return Ok(productos);
    }

    //Metodo GET para traer un unico Registro de la entidad Producto de la Db
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get(int id)
    {
         var producto = await _context.Productos.FindAsync(id);
         return Ok(producto);
    }
        
}
