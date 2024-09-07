using Microsoft.AspNetCore.Mvc;
using SistemaFinanceiro.Data;
using SistemaFinanceiro.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using SistemaFinanceiro.Data.SistemaFinanceiro.Data;

namespace SistemaFinanceiro.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var notasFiscais = _context.NotasFiscais.ToList();

            var model = new DashboardViewModel
            {
                ValorTotalEmitido = notasFiscais.Sum(n => n.Valor),
                ValorTotalEmitidoSemCobrança = notasFiscais
                    .Where(n => n.DataCobranca == null)
                    .Sum(n => n.Valor),
                ValorTotalInadimplente = notasFiscais
                    .Where(n => n.DataCobranca < DateTime.Now && n.DataPagamento == null)
                    .Sum(n => n.Valor),
                ValorTotalAVencer = notasFiscais
                    .Where(n => n.DataCobranca > DateTime.Now && n.DataPagamento == null)
                    .Sum(n => n.Valor),
                ValorTotalPago = notasFiscais
                    .Where(n => n.DataPagamento != null)
                    .Sum(n => n.Valor),
                InadimplenciaMensal = notasFiscais
                    .Where(n => n.DataCobranca.HasValue)
                    .GroupBy(n => new { n.DataCobranca.Value.Year, n.DataCobranca.Value.Month })
                    .Select(g => new DataValue
                    {
                        Mes = $"{g.Key.Month}/{g.Key.Year}",
                        Valor = g
                            .Where(n => n.DataPagamento == null)
                            .Sum(n => n.Valor)
                    })
                    .OrderBy(d => d.Mes)
                    .ToList(),
                ReceitaMensal = notasFiscais
                    .Where(n => n.DataPagamento.HasValue)
                    .GroupBy(n => new { n.DataPagamento.Value.Year, n.DataPagamento.Value.Month })
                    .Select(g => new DataValue
                    {
                        Mes = $"{g.Key.Month}/{g.Key.Year}",
                        Valor = g.Sum(n => n.Valor)
                    })
                    .OrderBy(d => d.Mes)
                    .ToList()
            };

            return View(model);
        }
    }
}
