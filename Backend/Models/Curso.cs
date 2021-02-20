
using System.Collections;
using Backend;

namespace Backend.Models
{
    public class Curso : Modelo
    {
        public long Id { get; set; }
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