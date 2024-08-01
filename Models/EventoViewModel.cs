using System;

namespace Atv4.Models
{
    public class EventoViewModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public DateTime Horario { get; set; }
        public string Local { get; set; }
        public int UsuarioId { get; set; }
    }
} 