using AmigosRESTAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Http;

namespace AmigosRESTAPI.Controllers {
    public class AmigoController : ApiController {
        private IAmigoRepository repository;

        public AmigoController() { }
        public AmigoController(IAmigoRepository repository) {
            this.repository = repository;
        }

        // GET:
        // exemplo http://localhost/AmigosRESTAPI/api/amigo
        [Route("api/amigo")]
        public IEnumerable<Utilizador> GetAll() {
            return repository.GetAll();
        }
        [Route("api/amigouni")]
        public IEnumerable<Utilizador> GetAll(int id)
        {
            return repository.GetAll(id);
        }
        [HttpGet]
        [Route("api/amigoinsert")]
        public IEnumerable<Utilizador> Insert(int id, string nome, string dataNascimento)
        {
            return repository.GetAll(id, nome, dataNascimento);
        }
        //Localizações
        //[Route("api/amigo")]
        //public IEnumerable<Utilizador> GetAll()
        //{
        //    return repository.GetAll();
        //}
        //[Route("api/amigouni")]
        //public IEnumerable<Utilizador> GetAll(int id)
        //{
        //    return repository.GetAll(id);
        //}
        //[HttpGet]
        //[Route("api/amigoinsert")]
        //public IEnumerable<Utilizador> Insert(int id, string nome, string dataNascimento)
        //{
        //    return repository.GetAll(id, nome, dataNascimento);
        //}
    }
}