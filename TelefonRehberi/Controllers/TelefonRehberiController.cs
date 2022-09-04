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
                          View(await _context.TelefonRehberleri.ToListAsync()) :
                          Problem("Entity set 'TelefonRehberiContext.TelefonRehberleri'  is null.");
        }

       

        // GET: TelefonRehberi/Create
        public IActionResult AddOrEdit(int id=0)
        {
            return View(new TelefonRehberi.Models.TelefonRehberi());
        }

        // POST: TelefonRehberi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("RehberId,Ad,Soyad,Telefon_Numarasi,Fax_Numarasi,E_Mail")] TelefonRehberi.Models.TelefonRehberi telefonRehberi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(telefonRehberi);
                 await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(telefonRehberi);
        }

        // GET: TelefonRehberi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TelefonRehberleri == null)
            {
                return NotFound();
            }

            var telefonRehberi = await _context.TelefonRehberleri
                .FirstOrDefaultAsync(m => m.RehberId == id);
            if (telefonRehberi == null)
            {
                return NotFound();
            }

            return View(telefonRehberi);
        }

    }
}
