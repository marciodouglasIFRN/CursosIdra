using System;
using System.Collections;

namespace CursosIdra.Models
{
    public class Estudante : Modelo
    {
        public string Nome { get; set; }
        public Cartao Cartao { get; set; }
        public ArrayList Pagamentos { get; set; }

        public Estudante():base(Banco.Estudantes){
            
        }

        public void RealizarMatricular(Curso Curso)
        {

        }

        public void RealizarPagamento(Curso Curso)
        {
            Pagamento Pagamento = new Pagamento();
            Pagamento.Curso = Curso;
            Pagamentos.Add(Pagamento);
        }

        public void CadastrarCartao(string Titular, string Numero, string Vencimento, string CodigoVerificacao)
        {
            this.Cartao = new Cartao();
            this.Cartao.Titular = Titular;
            this.Cartao.Numero = Numero;
            this.Cartao.Vencimento = Vencimento;
            this.Cartao.CodigoVerificacao = CodigoVerificacao;
        }
    }
}