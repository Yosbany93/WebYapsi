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
    public class SociosController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public SociosController(ApplicationDbContext context)
        {
            this.context = context;
        }
        
        // GET: api/<SociosController>
        [HttpGet]
        public async Task<ActionResult<List<Socio>>> Get()
        {
            return await context.Socios.ToListAsync();
        }        

        // POST api/<SociosController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Socio socio)
        {
            if (socio.SaldoTotal < 1000)
            {
                return BadRequest("El monto mínimo para aperturar la cuenta es de 1000 pesos");
            }
            var movimiento = new Movimientos();
            movimiento.Cantidad = socio.SaldoTotal;
            movimiento.IdTipoMovimiento = 1;
            context.Add(socio);
            await context.SaveChangesAsync();
            movimiento.IdSocio = socio.Id;
            context.Add(movimiento);
            await context.SaveChangesAsync();
            return Ok();
        }

        // PUT api/<SociosController>/5
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody] Socio socio)
        {
            if (socio.Id != id)
            {
                return BadRequest("El id del socio no coincide con el id de la URL");
            }
            var existe = await context.Socios.AnyAsync(x => x.Id == id);

            if (!existe)
            {
                return NotFound();
            }
            context.Update(socio);
            await context.SaveChangesAsync();
            return Ok();
        }

        // DELETE api/<SociosController>/5
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await context.Socios.AnyAsync(x => x.Id == id);

            if (!existe)
            {
                return NotFound();
            }
            var movimientos = await context.Movimientos.Where(x => x.IdSocio == id).ToListAsync();
            context.RemoveRange(movimientos);
            context.Remove(new Socio() { Id = id });
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
