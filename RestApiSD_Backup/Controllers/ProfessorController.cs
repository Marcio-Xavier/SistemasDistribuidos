using RestApiSD.Models;
using System.Web.Mvc;

namespace RestApiSD.Controllers
{
    public class ProfessorController : Controller
    {
        // GET: api/Professor
        [HttpGet]
        public JsonResult Get()
        {
            return Json(new RetornaProfessor().Lista(), JsonRequestBehavior.AllowGet);
        }

        // GET: api/Professor/id
        [HttpGet]
        public JsonResult GetById(int id)
        {
            return Json(new RetornaProfessor().Objeto(id), JsonRequestBehavior.AllowGet);
        }
    }
}
