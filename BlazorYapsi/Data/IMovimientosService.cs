using BlazorYapsi.Data.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorYapsi.Data
{
    public interface IMovimientosService
    {
        Task<IEnumerable<Movimiento>> GetMovimientos(int Id);
        Task<bool> PostSocio(int Id, Movimiento movimientos);
    }
}
