
using BibliotecaApp.Data;
using BibliotecaApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

public class AutoresController : Controller
{
    private readonly ApplicationDbContext _context;

    public AutoresController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: AUTORS
    public async Task<IActionResult> Index()    
    {
        var autores = await _context.Autores
        .Include(a => a.Pais)
        .Include(a => a.LibroAutores)
            .ThenInclude(la => la.Libro)
        .ToListAsync();

        return View(autores);
    }

    // GET: AUTORS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null) return NotFound();

        var autor = await _context.Autores
            .Include(a => a.Pais)
            .FirstOrDefaultAsync(m => m.Id == id);

        if (autor == null) return NotFound();

        return View(autor);
    }

    // GET: AUTORS/Create
    public IActionResult Create()
    {
        ViewData["PaisId"] = new SelectList(_context.Paises, "Id", "Nombre");
        return View();
    }

    // POST: AUTORS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Nombre,FechaNacimiento,PaisId")] Autor autor)
    {
        if (ModelState.IsValid)
        {
            _context.Add(autor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // SI FALLA LA VALIDACIÓN
        ViewData["PaisId"] = new SelectList(_context.Paises, "Id", "Nombre", autor.PaisId);
        return View(autor);
    }

    // GET: AUTORS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null) return NotFound();

        var autor = await _context.Autores
            .Include(a => a.Pais)
            .FirstOrDefaultAsync(a => a.Id == id);

        if (autor == null) return NotFound();

        ViewData["PaisId"] = new SelectList(_context.Paises, "Id", "Nombre", autor.PaisId);
        return View(autor);
    }

    // POST: AUTORS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,FechaNacimiento,PaisId")] Autor autor)
    {
        if (id != autor.Id) return NotFound();

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(autor);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Autores.Any(e => e.Id == autor.Id)) return NotFound();
                else throw;
            }
            return RedirectToAction(nameof(Index));
        }

        // SI FALLA LA VALIDACIÓN
        ViewData["PaisId"] = new SelectList(_context.Paises, "Id", "Nombre", autor.PaisId);
        return View(autor);
    }

    // GET: AUTORS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var autor = await _context.Autores
            .FirstOrDefaultAsync(m => m.Id == id);
        if (autor == null)
        {
            return NotFound();
        }

        return View(autor);
    }

    // POST: AUTORS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var autor = await _context.Autores.FindAsync(id);
        if (autor != null)
        {
            _context.Autores.Remove(autor);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool AutorExists(int? id)
    {
        return _context.Autores.Any(e => e.Id == id);
    }
}
