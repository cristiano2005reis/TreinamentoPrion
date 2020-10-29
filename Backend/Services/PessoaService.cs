using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Services
{
    public class PessoaService : GenericService<Pessoa>
    {
        public PessoaService()
        {
            repository = new Repositories.PessoaRepository();
        }
    }
}
