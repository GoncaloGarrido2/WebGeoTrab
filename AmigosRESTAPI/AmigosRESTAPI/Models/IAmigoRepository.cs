using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace AmigosRESTAPI.Models {
    public interface IAmigoRepository
    {
        IEnumerable<Utilizador> GetAll();
        IEnumerable<Utilizador> GetAll([FromBody] int pId);
        IEnumerable<Utilizador> GetAll(int id, string nome, string dataNascimento);
    }
}
