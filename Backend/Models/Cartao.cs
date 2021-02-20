namespace Backend.Models
{
    public class Cartao
    {
        public long Id { get; set; }
        public string Titular { get; set; }
        public string Numero { get; set; }
        public string Vencimento { get; set; }
        public string CodigoVerificacao { get; set; }
    }
}