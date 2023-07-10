using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class UserController : BaseApiController
{
    //creamos el constructor de la clase
    private readonly ProyectoBackendContext _context;
    
    public UserController(ProyectoBackendContext context)
    {
       _context = context;
    }

    //Metodo GET para listar todos los Registros de la entidad User de la Db
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<User>>> Get()
    {
         var users = await _context.Users.ToListAsync();
         return Ok(users);
    }

    //Metodo GET para traer un solo Registro de la entidad User de la Db
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get(int id)
    {
         var user = await _context.Users.FindAsync(id);
         return Ok(user);
    }
        
}
