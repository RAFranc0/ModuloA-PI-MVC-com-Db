using System;
using Atv4.Models;

namespace Atv4.Models
{
    public class ContatoViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Motivo { get; set; }
        public string Descricao { get; set; }
    }
} 