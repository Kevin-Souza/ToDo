using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        //GET: Tarefas/Details/5

        public async Task<IActionResult> Details(int? id) //método assincrono //? quer dizer que ele recebe valores nulos
        {
            if (id == null)
            {
                return NotFound();
            }

            var tarefa = await _appCont.Tarefas //await significa que ele está esperando uma resposta do servidor/Banco de dados
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tarefa == null)
            {
                return NotFound();
            }

            return View(tarefa);
        }
    }
}
