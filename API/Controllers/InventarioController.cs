using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class InventarioController : BaseApiController
{
    //generamos el constructor de la clase 
    private readonly ProyectoBackendContext _context;
    
    public InventarioController(ProyectoBackendContext context)
    {
       _context = context;
    }

    //Metodo get para traer todos los regidtros de la entidad Inventario de la Db
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Inventario>>> Get()
    {
         var inventarios = await _context.Inventarios.ToListAsync();
         return Ok(inventarios);
    }

    //Metodo get para traer un unico registro de la entidad Inventario de las Db
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get(int id)
    {
         var inventario = await _context.Inventarios.FindAsync(id);
         return Ok(inventario);
    }
        
}
