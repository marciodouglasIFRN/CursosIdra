using System.Collections;
namespace Backend.Models
{
    public abstract class Modelo
    {
        protected ArrayList lista;
        public Modelo(ArrayList lista){
            this.lista = lista;
        }

        public void salvar(){
            lista.Add(this);
        }

        public ArrayList todos(){
            return this.lista;
        }
    }

}