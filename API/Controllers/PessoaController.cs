using Backend.Entities;
using Backend.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Controllers
{
    public class PessoaController : BaseController<Pessoa>
    {
        public PessoaController()
        {
            service = new PessoaService();
        }
    }
}