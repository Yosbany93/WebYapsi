using BlazorYapsi.Data.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorYapsi.Data
{
    public interface ISociosService
    {
        Task<IEnumerable<Socio>> GetSociosAsync();
        Task<bool> FormSocio(int Id, Socio socio);

        Task<bool> PostSocio(Socio socio);
        Task<bool> DeleteSocio(int Id);
    }
}
