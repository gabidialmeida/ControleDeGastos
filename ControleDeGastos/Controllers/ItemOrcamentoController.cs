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
    public class ItemOrcamentoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemOrcamentoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ItemOrcamento
        public async Task<IActionResult> Index()
        {
            return View(await _context.ItemOrcamento.ToListAsync());
        }
        public async Task<List<Categoria>> ListaCategorias()
        {
            var categorias = _context.Categoria;
            return await categorias.ToListAsync();
        }
        // GET: ItemOrcamento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemOrcamento = await _context.ItemOrcamento
                .FirstOrDefaultAsync(m => m.ID == id);
            if (itemOrcamento == null)
            {
                return NotFound();
            }

            return View(itemOrcamento);
        }

        // GET: ItemOrcamento/Create
        public IActionResult Create(int? id)
        {
            var categorias = ListaCategorias().Result;
            ViewBag.Categorias = new SelectList(categorias, "ID", "Descricao");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Descricao,Categoria,Valor,Orcamento")] ItemOrcamento itemOrcamento, int? id)
        {
            if (ModelState.IsValid)
            {
                itemOrcamento.Orcamentos = await _context.Orcamento
                .FirstOrDefaultAsync(m => m.ID == id);
                _context.Add(itemOrcamento);
                //_context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(itemOrcamento);
        }

        // GET: ItemOrcamento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemOrcamento = await _context.ItemOrcamento.FindAsync(id);
            if (itemOrcamento == null)
            {
                return NotFound();
            }
            return View(itemOrcamento);
        }

        // POST: ItemOrcamento/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Descricao,Valor")] ItemOrcamento itemOrcamento)
        {
            if (id != itemOrcamento.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(itemOrcamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemOrcamentoExists(itemOrcamento.ID))
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
            return View(itemOrcamento);
        }

        // GET: ItemOrcamento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemOrcamento = await _context.ItemOrcamento
                .FirstOrDefaultAsync(m => m.ID == id);
            if (itemOrcamento == null)
            {
                return NotFound();
            }

            return View(itemOrcamento);
        }

        // POST: ItemOrcamento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var itemOrcamento = await _context.ItemOrcamento.FindAsync(id);
            _context.ItemOrcamento.Remove(itemOrcamento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemOrcamentoExists(int id)
        {
            return _context.ItemOrcamento.Any(e => e.ID == id);
        }
    }
}
