using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIYapsi.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIYapsi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovimientosController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public MovimientosController(ApplicationDbContext context)
        {
            this.context = context;
        }
        // GET: api/<MovimientosController>
        [HttpGet("{idSocio:int}")]
        public async Task<ActionResult<List<Movimientos>>> Get(int idSocio)
        {

            return await context.Movimientos.Where(x => x.IdSocio == idSocio).ToListAsync();
        }

       
        [HttpPost("{idSocio:int}")]
        public async Task<ActionResult> Post([FromBody] Movimientos movimientos, int idSocio)
        {
            var existe = await context.Socios.AnyAsync(x => x.Id == idSocio);

            if (!existe)
            {
                return NotFound();
            }
            var socio = await context.Socios.FirstOrDefaultAsync(x => x.Id == idSocio);
            movimientos.IdSocio = idSocio;
            socio.SaldoTotal = movimientos.IdTipoMovimiento == 2 ? socio.SaldoTotal + movimientos.Cantidad : socio.SaldoTotal - movimientos.Cantidad;
            if (socio.SaldoTotal < 0)
            {
                return BadRequest("No tiene sufieciente saldo para retirar esa cantidad");
            }
            context.Add(movimientos);
            await context.SaveChangesAsync();
            return Ok();
        }

        
    }
}
