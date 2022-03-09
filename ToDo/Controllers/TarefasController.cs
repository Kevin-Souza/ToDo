using Microsoft.AspNetCore.Mvc;
using ToDo.Data;

namespace ToDo.Controllers
{
    public class TarefasController : Controller
    {
        private readonly AppCont _appCont;

        public TarefasController(AppCont appCont)
        {
            _appCont = appCont;
        }

        //Action sincrona, manda uma RC para o servidor e irá esperar a resposta para continuar.
        public IActionResult Index() // um Método IActionResult espera o retorno de uma view.
        {
            var allTasks = _appCont.Tarefas.ToList();
            // _appCont: caminho do banco,  ToList: seria o select *
            return View(allTasks);
        }
    }
}
