using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ControleDeGastos.Data;
using ControleDeGastos.Models;

namespace ControleDeGastos.Views
{
    public class OrcamentosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrcamentosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Orcamentoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Orcamento.ToListAsync());
        }

        public async Task<List<Mes>> ListaMeses()
        {
            var meses = _context.Mes.ToListAsync();
            return await meses;
        }
        public async Task<List<Categoria>> ListaCategorias()
        {
            var categorias = _context.Categoria;
            return await categorias.ToListAsync();
        }
        // GET: Orcamentoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orcamento = await _context.Orcamento
                .FirstOrDefaultAsync(m => m.ID == id);
            if (orcamento == null)
            {
                return NotFound();
            }

            return View(orcamento);
        }

        // GET: Orcamentoes/Create
        public IActionResult Create()
        {
            var meses = ListaMeses();
            ViewData["Meses"] = new SelectList(meses.Result, "Id", "Mes");
            var categorias = ListaCategorias().Result;

            ViewBag.Categorias = new SelectList(categorias, "Id", "Categoria"); 
            return View();
        }

        // POST: Orcamentoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Ano,Descricao,Valor,Mes,Categoria")] Orcamento orcamento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orcamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(orcamento);
        }

        // GET: Orcamentoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orcamento = await _context.Orcamento.FindAsync(id);
            if (orcamento == null)
            {
                return NotFound();
            }
            return View(orcamento);
        }

        // POST: Orcamentoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Ano,Descricao,Valor,Mes,Categoria")] Orcamento orcamento)
        {
            if (id != orcamento.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orcamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrcamentoExists(orcamento.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(orcamento);
        }

        // GET: Orcamentoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orcamento = await _context.Orcamento
                .FirstOrDefaultAsync(m => m.ID == id);
            if (orcamento == null)
            {
                return NotFound();
            }

            return View(orcamento);
        }

        // POST: Orcamentoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orcamento = await _context.Orcamento.FindAsync(id);
            _context.Orcamento.Remove(orcamento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrcamentoExists(int id)
        {
            return _context.Orcamento.Any(e => e.ID == id);
        }
    }
}
