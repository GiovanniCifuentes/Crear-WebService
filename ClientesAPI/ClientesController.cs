using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClientesAPI.Data;
using ClientesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClientesAPI.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ClientesController(AppDbContext context)
        {
            _context = context;
        }

        // POST: api/clientes
        [HttpPost]
        public async Task<ActionResult<ModelsCliente>> CrearCliente(ModelsCliente cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(CrearCliente), new { id = cliente.Id }, cliente);
        }

        // GET: api/clientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ModelsCliente>>> GetClientes()
        {
            return await _context.Clientes.ToListAsync();
        }
    }
}
