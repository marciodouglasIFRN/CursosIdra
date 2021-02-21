using System;
using System.Collections;
using CursosIdra;

namespace CursosIdra.Models
{
    public class Curso : Modelo
    {
        public string Nome { get; set; }
        public ArrayList Estudantes { get; }
        public Curso():base(Banco.Cursos){
            
        }

        public void InserirEstudante(Estudante Estudante)
        {
            Estudantes.Add(Estudante); 
        }

    }
}