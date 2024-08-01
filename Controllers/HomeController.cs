using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Atv4.Data;
using Atv4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Atv4.Controllers
{
    public class HomeController : Controller
    {
        private readonly MADbContext _context;

        public HomeController(MADbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var Eventos = await _context.Eventos.ToListAsync();
            return View(Eventos);
        }

        public IActionResult Sobre()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult CadastroUsuario()
        {
            return View();
        }

        public IActionResult PainelUsuario()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EnviarContato(ContatoViewModel contato)
        {
            if (!ModelState.IsValid)
            {
                ViewData["mensagem"] = "Informações inválidas";
                return View("Contato", contato);
            }
            return View("ConfirmacaoEnvio", contato);
        }
    }
}
