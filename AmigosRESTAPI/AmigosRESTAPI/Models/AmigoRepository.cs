using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmigosRESTAPI.Models {
    public class AmigoRepository : IAmigoRepository {
        public IEnumerable<Amigo> GetAll() {
            return new Amigo[] {
                new Amigo {IdAmigo = 1000, Nome = "Zeferino"},
                new Amigo {IdAmigo = 1001, Nome = "Sebastiao" },
                new Amigo {IdAmigo = 1002, Nome = "Valentim"},
                new Amigo {IdAmigo = 1003, Nome = "Vilaça"}
            };
        }
        public IEnumerable<Amigo> GetAll(int pId)
        {
            return new Amigo[] {
                new Amigo {IdAmigo = 1000, Nome = "Zeferino"}
            };
        }
    }
}