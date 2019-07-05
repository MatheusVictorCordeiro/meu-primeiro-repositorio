using System.Collections.ObjectModel;
using System.Linq;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UsuarioController : Controller
    {

        public ActionResult Usuario()
        {
            var usuario = new Usuario();
            return View(usuario);



        }

        [HttpPost]
        public ActionResult Usuario(Usuario usuario)    ///Com Validação, se for valido vai redirecionar para a pagina resultado
        {
            if (ModelState.IsValid)
            {

                return View("resultado", usuario);

            }
            return View(usuario);

        }

        public ActionResult Resultado(Usuario usuario)
        {

            return View(usuario);

        }

        public ActionResult LoginUnico(string login)
        {
            var bdExemplo = new Collection<string>
            {

                "Hugo",
                "Matheus",
                "Freitas"

            };
            return Json(bdExemplo.All(x => x.ToLower() != login.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}