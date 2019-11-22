using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ControleDeGastos.Data;
using ControleDeGastos.Models;

namespace ControleDeGastos.Controllers
{
    public class RelatoriosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RelatoriosController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TotalOrcamento()
        {
            return View();
        }
        public IActionResult TotalOrcamento2(int? mes)
        {
            //var selected = ViewBag.Meses;
            double total=0;
            var orcamentos = _context.ItemOrcamento.Where(m => m.Orcamentos.Mes.Id == mes).ToListAsync().Result;
            orcamentos.ForEach(x =>
            {
                total += x.Valor;
            });
            ViewBag.Total = total;
            return View();
        }
        public IActionResult TotalGastos()
        {
            return View();
        }
        public IActionResult TotalGastos2(int? mes)
        {
            //var selected = ViewBag.Meses;
            double total = 0;
            var gastos = _context.Gastos.Where(g=> g.Mes.Id==mes).ToListAsync().Result;
            gastos.ForEach(x =>
            {
                total += x.Valor;
            });

            ViewBag.Total = total;
            return View();
        }
        public IActionResult TotalGastosCategoria()
        {
            return View();
        }
        public IActionResult TotalGastosCategoria2(int? mes, int? categoria)
        {
            double total = 0;
            var gastos = _context.Gastos.Where(g => g.Mes.Id == mes && g.Categoria.ID == categoria).ToListAsync().Result;
            gastos.ForEach(x =>
            {
                total += x.Valor;
            });

            ViewBag.Total = total;
            return View();
        }
        public IActionResult TotalSaldo()
        {
            return View();
        }
        public IActionResult TotalSaldo2(int? mes)
        {
            double totalGastos=0, totalOrcamento=0, total=0 ;
            var gastos = _context.Gastos.Where(g => g.Mes.Id == mes).ToListAsync().Result;
            var orcamentos = _context.ItemOrcamento.Where(m => m.Orcamentos.Mes.Id == mes).ToListAsync().Result;

            orcamentos.ForEach(x =>
            {
                totalOrcamento += x.Valor;
            });

            gastos.ForEach(x =>
            {
                totalGastos += x.Valor;
            });
            total = totalOrcamento - totalGastos;
            ViewBag.Total = total;
            return View();
        }
        public IActionResult TotalGastosConta()
        {
            return View();
        }
        public IActionResult TotalGastosConta2(int? mes, int? conta)
        {
            double total = 0;
            var gastos = _context.Gastos.Where(g => g.Mes.Id == mes && g.Conta.ID == conta).ToListAsync().Result;
            gastos.ForEach(x =>
            {
                total += x.Valor;
            });

            ViewBag.Total = total;
            return View();
        }

        public IActionResult TotalGastosPeriodo()
        {
            return View();
        }
        public IActionResult TotalGastosPeriodo2(int? mesInicio, int? mesFim, int? anoInicio, int? anoFim)
        {
            double total = 0;
            var gastos = _context.Gastos.Where(g => g.Ano >= anoInicio && g.Ano <= anoFim && g.Mes.Id >= mesInicio && g.Mes.Id <= mesFim).ToListAsync().Result;
            gastos.ForEach(x =>
            {
                total += x.Valor;
            });

            ViewBag.Total = total;
            return View();
        }
    }
}