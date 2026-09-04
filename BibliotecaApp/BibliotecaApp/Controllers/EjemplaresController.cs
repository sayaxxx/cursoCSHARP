
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BibliotecaApp.Models;
using BibliotecaApp.Data;

public class EjemplaresController : Controller
{
    private readonly ApplicationDbContext _context;

    public EjemplaresController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: EJEMPLARS
    public async Task<IActionResult> Index()    
    {
        var ejemplares = await _context.Ejemplares
        .Include(e => e.Libro)
        .Include(e => e.Prestamos)
            .ThenInclude(p => p.Usuario)
        .ToListAsync();

        return View(ejemplares);
    }

    // GET: EJEMPLARS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var ejemplar = await _context.Ejemplares
            .FirstOrDefaultAsync(m => m.Id == id);
        if (ejemplar == null)
        {
            return NotFound();
        }

        return View(ejemplar);
    }

    // GET: EJEMPLARS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: EJEMPLARS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Estado,LibroId,Libro,Prestamos")] Ejemplar ejemplar)
    {
        if (ModelState.IsValid)
        {
            _context.Add(ejemplar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(ejemplar);
    }

    // GET: EJEMPLARS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var ejemplar = await _context.Ejemplares.FindAsync(id);
        if (ejemplar == null)
        {
            return NotFound();
        }
        return View(ejemplar);
    }

    // POST: EJEMPLARS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,Estado,LibroId,Libro,Prestamos")] Ejemplar ejemplar)
    {
        if (id != ejemplar.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(ejemplar);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EjemplarExists(ejemplar.Id))
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
        return View(ejemplar);
    }

    // GET: EJEMPLARS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var ejemplar = await _context.Ejemplares
            .FirstOrDefaultAsync(m => m.Id == id);
        if (ejemplar == null)
        {
            return NotFound();
        }

        return View(ejemplar);
    }

    // POST: EJEMPLARS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var ejemplar = await _context.Ejemplares.FindAsync(id);
        if (ejemplar != null)
        {
            _context.Ejemplares.Remove(ejemplar);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool EjemplarExists(int? id)
    {
        return _context.Ejemplares.Any(e => e.Id == id);
    }
}
