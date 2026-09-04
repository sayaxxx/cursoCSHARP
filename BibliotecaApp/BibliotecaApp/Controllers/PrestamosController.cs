
using BibliotecaApp.Data;
using BibliotecaApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

public class PrestamosController : Controller
{
    private readonly ApplicationDbContext _context;

    public PrestamosController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: PRESTAMOS
    public async Task<IActionResult> Index()    
    {
        var prestamos = await _context.Prestamos
        .Include(p => p.Usuario)
        .Include(p => p.Ejemplar)
            .ThenInclude(e => e.Libro)
        .ToListAsync();

        return View(await _context.Prestamos.ToListAsync());
    }

    // GET: PRESTAMOS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null) return NotFound();

        var prestamo = await _context.Prestamos
            .Include(p => p.Usuario)
            .Include(p => p.Ejemplar)
                .ThenInclude(e => e.Libro)
            .FirstOrDefaultAsync(m => m.Id == id);

        if (prestamo == null) return NotFound();

        return View(prestamo);
    }

    // GET: PRESTAMOS/Create
    public IActionResult Create()
    {
        // Mostrar el título del libro asociado al ejemplar en lugar de solo el ID
        ViewData["EjemplarId"] = new SelectList(_context.Ejemplares.Include(e => e.Libro)
            .Select(e => new { e.Id, Descripcion = $"{e.Libro.Titulo} (Ejemplar #{e.Id})" }), "Id", "Descripcion");

        // Mostrar el nombre del usuario
        ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Nombre");
        return View();
    }

    // POST: PRESTAMOS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,FechaPrestamo,FechaDevolucion,EjemplarId,UsuarioId")] Prestamo prestamo)
    {
        if (ModelState.IsValid)
        {
            _context.Add(prestamo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // SI FALLA LA VALIDACIÓN: Volver a cargar las listas desplegables
        ViewData["EjemplarId"] = new SelectList(
            _context.Ejemplares.Include(e => e.Libro)
                .Select(e => new { e.Id, Descripcion = $"{e.Libro.Titulo} (Ejemplar #{e.Id})" }),
            "Id",
            "Descripcion",
            prestamo.EjemplarId
        );

        ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Nombre", prestamo.UsuarioId);

        return View(prestamo);
    }

    // GET: PRESTAMOS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var prestamo = await _context.Prestamos
            .Include(p => p.Usuario)
            .Include(p => p.Ejemplar)
                .ThenInclude(e => e.Libro)
            .FirstOrDefaultAsync(p => p.Id == id);

        if (prestamo == null)
        {
            return NotFound();
        }

        // Cargar listas desplegables pasando el ID seleccionado actualmente
        ViewData["EjemplarId"] = new SelectList(
            _context.Ejemplares.Include(e => e.Libro)
                .Select(e => new { e.Id, Descripcion = $"{e.Libro.Titulo} (Ejemplar #{e.Id})" }),
            "Id",
            "Descripcion",
            prestamo.EjemplarId
        );

        ViewData["UsuarioId"] = new SelectList(
            _context.Usuarios,
            "Id",
            "Nombre",
            prestamo.UsuarioId
        );

        return View(prestamo);
    }

    // POST: PRESTAMOS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Id,FechaPrestamo,FechaDevolucion,EjemplarId,UsuarioId")] Prestamo prestamo)
    {
        if (id != prestamo.Id) return NotFound();

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(prestamo);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Prestamos.Any(e => e.Id == prestamo.Id)) return NotFound();
                else throw;
            }
            return RedirectToAction(nameof(Index));
        }

        // SI FALLA LA VALIDACIÓN: Volver a cargar las listas desplegables
        ViewData["EjemplarId"] = new SelectList(
            _context.Ejemplares.Include(e => e.Libro)
                .Select(e => new { e.Id, Descripcion = $"{e.Libro.Titulo} (Ejemplar #{e.Id})" }),
            "Id",
            "Descripcion",
            prestamo.EjemplarId
        );

        ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Nombre", prestamo.UsuarioId);

        return View(prestamo);
    }

    // GET: PRESTAMOS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var prestamo = await _context.Prestamos
            .FirstOrDefaultAsync(m => m.Id == id);
        if (prestamo == null)
        {
            return NotFound();
        }

        return View(prestamo);
    }

    // POST: PRESTAMOS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var prestamo = await _context.Prestamos.FindAsync(id);
        if (prestamo != null)
        {
            _context.Prestamos.Remove(prestamo);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool PrestamoExists(int? id)
    {
        return _context.Prestamos.Any(e => e.Id == id);
    }
}
