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
        public IEnumerable<Modelo> Index()
        {
            return Enumerable.Range(1, 5).Select(index => new Curso
            {
                Id = index,
                Nome = "Nome" + index
            })
            .ToArray();
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
