using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var pessoa = new Pessoa()
            {
                PessoaId = 1,
                Nome = "Matheus",
                Tipo = "Funcionario"

            };
          


            
            return View (pessoa);

        }

        public ActionResult Contatos()
        {

            return View();

        }
        [HttpPost] // sempre que for utilizar metodo post em uma função, usar [HttpPost]
        public ActionResult Lista(Pessoa pessoa)
        {



            
            return View(pessoa);

        }




    }
}