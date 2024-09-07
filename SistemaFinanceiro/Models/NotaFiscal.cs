using System.ComponentModel.DataAnnotations;

namespace SistemaFinanceiro.Models
{
    public class NotaFiscal
    {

        [Key]
        public int NotaId { get; set; }

        public int PagadorId { get; set; }
        public DateTime? DataEmissao { get; set; } // Nullable<DateTime>
        public DateTime? DataCobranca { get; set; } // Nullable<DateTime>
        public DateTime? DataPagamento { get; set; } // Nullable<DateTime>
        public decimal Valor { get; set; }
        public string DocumentoNota { get; set; }
        public string DocumentoBoleto { get; set; }
        public string Status { get; set; }

        public Pagador Pagador { get; set; }  // Relação com a classe Pagador

        // Propriedades adicionais para exibição
        public string NomePagador => Pagador?.Nome;  // Assumindo que 'Nome' é uma propriedade de 'Pagador'
        public string NumeroIdentificacao => NotaId.ToString();
    }
}
