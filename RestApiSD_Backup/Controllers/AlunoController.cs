using RestApiSD_Backup.Models;
using System.Web.Mvc;

namespace RestApiSD_Backup.Controllers
{
    public class AlunoController : Controller
    {
        // GET: api/Aluno
        [HttpGet]
        public JsonResult Get()
        {
            return Json(new RetornaAluno().Lista(), JsonRequestBehavior.AllowGet);
        }

        // GET: api/Aluno/id
        [HttpGet]
        public JsonResult GetById(int id)
        {
            return Json(new RetornaAluno().Objeto(id), JsonRequestBehavior.AllowGet);
        }
    }
}
