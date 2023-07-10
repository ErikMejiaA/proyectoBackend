using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class HistorialController : BaseApiController
{
    //creamos el constructor de la clase
    private readonly ProyectoBackendContext _context;
    
    public HistorialController(ProyectoBackendContext context)
    {
       _context = context;
    }

    //Metodo GET para traer todos los registros de la entidad Historial de la Db
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Inventario>>> Get()
    {
         var inventarios = await _context.Inventarios.ToListAsync();
         return Ok(inventarios);
    }

    //Metodo GET para traer un solo registro de la entidad Historial de la Db
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get(int id)
    {
         var inventario = await _context.Inventarios.FindAsync(id);
         return Ok(inventario);
    }
        
}
