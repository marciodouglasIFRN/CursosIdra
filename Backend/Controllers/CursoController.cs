using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Backend.Models;
using Backend;
using System.Collections;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CursoController : ControllerBase
    {

        [HttpGet]
        public ArrayList Get()
        {
            return Banco.Cursos;
        }

        [HttpPost]
        public string Post()
        {
            Curso curso = new Curso();
            curso.Nome = "Márco Dougas Xavier";
            curso.Id = 1;
            Banco.Cursos.Add(curso);
            return "Curso Cadastrado";
        }
    }
}
