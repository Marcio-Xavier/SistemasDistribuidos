using RestApiSD.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace RestApiSD.Controllers
{
    public class ProfessorController : ApiController
    {
        // GET: api/Professor
        public List<Professor> Get()
        {
            return new RetornaProfessor().Lista();
        }

        // GET: api/Professor/id
        public Professor Get(int id)
        {
            return new RetornaProfessor().Objeto(id);
        }
    }
}
