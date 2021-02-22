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
    public class CursoController : ControllerBase
    {

        [HttpGet]
        public IEnumerable Index()
        {
            return Curso.Todos() != null ? Curso.Todos().Values.ToArray() : new Curso[0];
        }
        
        [HttpGet("{id:long}")]
        public Modelo Get(long Id)
        {
            return Curso.Get(Id);
        }

        [HttpPost]
        public string Post()
        {
            Curso Curso = new Curso();
            Curso.Nome = "Nome";
            Curso.Salvar();
            return "Curso Cadastrado";
        }
        
    }
}
