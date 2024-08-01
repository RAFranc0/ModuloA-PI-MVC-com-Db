using System.Linq;
using System.Threading.Tasks;
using Atv4.Data;
using Atv4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class EventosController : Controller
{
    private readonly MADbContext _context;

    public EventosController(MADbContext context)
    {
        _context = context;
    }

    public IActionResult AdicionarEventos()
    {
        return View();
    }

    public async Task<IActionResult> ExcluirEventos()
    {
        var Eventos = await _context.Eventos.ToListAsync();
        return View(Eventos);
    }

    public async Task<IActionResult> EditarEventos()
    {
        var Eventos = await _context.Eventos.ToListAsync();
        return View(Eventos);
    }

    public async Task<IActionResult> ListarEventos()
    {
        var Eventos = await _context.Eventos.ToListAsync();
        return View(Eventos);
    }

    public async Task<IActionResult> ConfirmarExclusao(int id)
    {
        var evento = await _context.Eventos.FindAsync(id);
        if (evento == null)
        {
            return NotFound();
        }
        return View(evento);
    }

    public async Task<IActionResult> TelaEdicao(int id)
    {
        var evento = await _context.Eventos.FindAsync(id);
        if (evento == null)
        {
            return NotFound();
        }
        return View(evento);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Adicionar(EventoViewModel evento)
    {
        if (ModelState.IsValid)
        {
            _context.Eventos.Add(evento);
            await _context.SaveChangesAsync();
            return RedirectToAction("PainelUsuario", "Home");
        }

        return View(evento);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Excluir(int id)
    {
        var evento = await _context.Eventos.FindAsync(id);
        if (evento == null)
        {
            return NotFound();
        }

        _context.Eventos.Remove(evento);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(ExcluirEventos));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Editar(int id, [Bind("Id,Nome,Origem,Destino,Saida,Retorno,Atrativos")] EventoViewModel evento)
    {
        if (id != evento.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(evento);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!eventoExists(evento.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction("PainelUsuario", "Home");
        }
        return View(evento);
    }

    private bool eventoExists(int id)
    {
        return _context.Eventos.Any(e => e.Id == id);
    }
}