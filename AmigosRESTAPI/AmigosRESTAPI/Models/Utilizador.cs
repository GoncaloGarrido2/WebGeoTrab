using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmigosRESTAPI.Models
{
    public class Utilizador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int IdLocalizacao { get; set; }
    }
}