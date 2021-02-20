namespace Backend.Models
{
    public class Pagamento
    {
        public long Id { get; set; }
        public Curso Curso { get; set; }
        public double Valor { get; set; }
    }
}