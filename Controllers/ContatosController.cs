using System.Linq;
using System.Threading.Tasks;
using Atv4.Data;
using Atv4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class ContatosController : Controller
{
    private readonly MADbContext _context;

    public ContatosController(MADbContext context)
    {
        _context = context;
    }

    public IActionResult Contato()
    {
        return View();
    }

    public IActionResult ConfirmacaoEnvio()
    {
        return View();
    }

    public async Task<IActionResult> ExcluirContatos()
    {
        var Contatos = await _context.Contatos.ToListAsync();
        return View(Contatos);
    }

    public async Task<IActionResult> ConfirmarExclusao(int id)
    {
        var contato = await _context.Contatos.FindAsync(id);
        if (contato == null)
        {
            return NotFound();
        }
        return View(contato);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> EnviarContato(ContatoViewModel contato)
    {
        if (ModelState.IsValid)
        {
            _context.Contatos.Add(contato);
            await _context.SaveChangesAsync();
            return RedirectToAction("ConfirmacaoEnvio", "Contatos", contato);
        }

        return View(contato);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Excluir(int id)
    {
        var contato = await _context.Contatos.FindAsync(id);
        if (contato == null)
        {
            return NotFound();
        }

        _context.Contatos.Remove(contato);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(ExcluirContatos));
    }

    private bool contatoExists(int id)
    {
        return _context.Contatos.Any(e => e.Id == id);
    }
}
