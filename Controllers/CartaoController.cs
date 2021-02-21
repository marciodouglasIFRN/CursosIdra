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
    public class CartaoController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Modelo> Index()
        {
            return Enumerable.Range(1, 5).Select(index => new Cartao
            {
                Id = index,
                Titular = "Nome" + index,
                Numero = "Nome" + index,
                Vencimento = "Nome" + index,
                CodigoVerificacao = "Nome" + index,
            })
            .ToArray();
        }
        
        [HttpGet("{id:long}")]
        public Modelo Get(long Id)
        {
            return Cartao.Get(Id);
        }

        [HttpPost]
        public Cartao Post()
        {
            Console.WriteLine("Hi popst!");
            return new Cartao();
        }
        
    }
}
