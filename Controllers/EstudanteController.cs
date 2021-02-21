using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CursosIdra.Models;
using CursosIdra;
using System.Collections;

namespace CursosIdra.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstudanteController : ControllerBase
    {

        [HttpGet]
        public Dictionary<long, Modelo> Index()
        {
            return Estudante.Todos();
        }
        
        [HttpGet("{id:long}")]
        public Modelo Get(long Id)
        {
            return Estudante.Get(Id);
        }

        [HttpPost]
        public string Post()
        {
            
            return "Estudante Cadastrado";
        }

        [HttpDelete]
        public string Delete()
        {
            return "Estudante Deletado";
        }

        [HttpPut]
        public string Put()
        {
            return "Curso Atualizado";
        }

        
    }
}
