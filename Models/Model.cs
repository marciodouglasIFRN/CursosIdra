using System;
using System.Collections;
using System.Collections.Generic;
namespace CursosIdra.Models
{
    public abstract class Modelo
    {
        private static Dictionary<long, Modelo> Lista;

        public long Id { get; set; }
        public Modelo(Dictionary<long, Modelo> ListaParamentro){
            Lista = ListaParamentro;
        }

        public void Salvar(){
            this.Id = Lista.Count+1;
            Lista.Add(this.Id,this);
        }
        public static Modelo Get(long Id){
            return Lista[Id];
        }    

        public static Dictionary<long, Modelo> Todos(){
            return Lista;
        }
    }

}