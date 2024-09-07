using System.Collections.Generic;

namespace SistemaFinanceiro.Models
{
    public class DashboardViewModel
    {
        public decimal ValorTotalEmitido { get; set; }
        public decimal ValorTotalEmitidoSemCobrança { get; set; }
        public decimal ValorTotalInadimplente { get; set; }
        public decimal ValorTotalAVencer { get; set; }
        public decimal ValorTotalPago { get; set; }
        public List<DataValue> InadimplenciaMensal { get; set; }
        public List<DataValue> ReceitaMensal { get; set; }
    }

    public class DataValue
    {
        public string Mes { get; set; }
        public decimal Valor { get; set; }
    }
}