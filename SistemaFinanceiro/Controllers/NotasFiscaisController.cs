using Microsoft.AspNetCore.Mvc;
using System.Linq;
using SistemaFinanceiro.Data;
using SistemaFinanceiro.Models;
using SistemaFinanceiro.Data.SistemaFinanceiro.Data;

namespace SistemaFinanceiro.Controllers
{
    public class NotasFiscaisController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NotasFiscaisController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string status, string mesEmissao, string mesCobrança, string mesPagamento)
        {
            var notas = _context.NotasFiscais.AsQueryable();

            if (!string.IsNullOrEmpty(status))
            {
                notas = notas.Where(n => n.Status == status);
            }

            if (int.TryParse(mesEmissao, out int mesEmissaoInt))
            {
                notas = notas.Where(n => n.DataEmissao.HasValue && n.DataEmissao.Value.Month == mesEmissaoInt);
            }

            if (int.TryParse(mesCobrança, out int mesCobrançaInt))
            {
                notas = notas.Where(n => n.DataCobranca.HasValue && n.DataCobranca.Value.Month == mesCobrançaInt);
            }

            if (int.TryParse(mesPagamento, out int mesPagamentoInt))
            {
                notas = notas.Where(n => n.DataPagamento.HasValue && n.DataPagamento.Value.Month == mesPagamentoInt);
            }

            return View(notas.ToList());
        }

    }
}
