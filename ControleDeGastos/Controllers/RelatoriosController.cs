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
        public IActionResult TotalOrcamento2()
        {
            //var selected = ViewBag.Meses;
            int mes = 11;
            double total=0;
            var orcamentos = _context.ItemOrcamento.Where(m => m.Orcamentos.Mes.Id == mes).ToListAsync().Result;
            orcamentos.ForEach(x =>
            {
                total += x.Valor;
            });
            return View();
        }
    }
}