using RestApiSD_Backup.Models;
using System.Web.Mvc;

namespace RestApiSD_Backup.Controllers
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
