using System;
namespace CursosIdra.Models
{
    public class Cartao : Modelo
    {
        public string Titular { get; set; }
        public string Numero { get; set; }
        public string Vencimento { get; set; }
        public string CodigoVerificacao { get; set; }

        public Cartao():base(Banco.Cartoes){
            
        }
    }
}