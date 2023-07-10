using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class BodegaController : BaseApiController
{
    //generamos el constructor de la clase 
    private readonly ProyectoBackendContext _context;
    
    public BodegaController(ProyectoBackendContext context)
    {
       _context = context;
    }

    //Metodo GET para traer todos los registro de ls entidad Bodega de la Db
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Bodega>>> Get()
    {
         var bodegas = await _context.Bodegas.ToListAsync();
         return Ok(bodegas);
    }

    //Metodo GET para traer un unico Registro de la entidad Bodega de la Db
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get(int id)
    {
         var bodega = await _context.Bodegas.FindAsync(id);
         return Ok(bodega);
    }
        
}
