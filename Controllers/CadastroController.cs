using System;
using Atv4.Data;
using Atv4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class CadastroController : Controller
{
    private readonly MADbContext _context;

    public CadastroController(MADbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult Create(UsuarioViewModel u)
    {
        if (ModelState.IsValid)
        {
            _context.Add(u);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        return View(u);
    }
}
