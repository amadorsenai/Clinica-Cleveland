using Senai.Cleveland.WebApi.Domains;
using Senai.Cleveland.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Cleveland.WebApi.Repositories
{
    public class MedicosRepository : IMedicosInterface
    {
        public List<Medicos> ListarTodos()
        {
            using(ClevelandContext ctx = new ClevelandContext())
            {
                return ctx.Medicos.ToList();
            }
        }
    }
}
