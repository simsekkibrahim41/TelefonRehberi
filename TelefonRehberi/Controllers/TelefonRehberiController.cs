using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TelefonRehberi.Models;

namespace TelefonRehberi.Controllers
{
    public class TelefonRehberiController : Controller
    {
        private readonly TelefonRehberiContext _context;

        public TelefonRehberiController(TelefonRehberiContext context)
        {
            _context = context;
        }

        // GET: TelefonRehberi
        public async Task<IActionResult> Index()
        {
            return _context.TelefonRehberleri != null ?
                        View(await _context.TelefonRehberleri.OrderByDescending(x => x.RehberId).ToListAsync()) :
                        Problem("Entity set 'TelefonRehberiContext.TelefonRehberleri'  is null.");
        }



        // GET: TelefonRehberi/Create
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Rehber());
            else
                return View(_context.TelefonRehberleri.Find(id));

        }

        // POST: TelefonRehberi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("RehberId,Ad,Soyad,Telefon_Numarasi,Fax_Numarasi,E_Mail")] Rehber telefonRehberi)
        {
            if (ModelState.IsValid)
            {
                if (telefonRehberi.RehberId == 0)
                    _context.Add(telefonRehberi);
                else
                    _context.Update(telefonRehberi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(telefonRehberi);
        }

        // GET: TelefonRehberi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var sil = await _context.TelefonRehberleri.FindAsync(id);
            _context.TelefonRehberleri.Remove(sil);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));


        }

    }
}
