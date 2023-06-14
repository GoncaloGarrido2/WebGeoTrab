using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmigosRESTAPI.Models
{
    public class Localizacao
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataAtual { get; set; }
        public DateTime DataExpira { get; set; }
        public Point Localizacao { get; set; }
    }
}