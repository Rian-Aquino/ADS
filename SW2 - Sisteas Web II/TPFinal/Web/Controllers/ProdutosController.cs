using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Common.Services;
using API.Models;

namespace Web.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly ProdutosService _produtosService = new ProdutosService("https://localhost:7166", new HttpClient());

        // GET: Produtos
        public async Task<IActionResult> Index()
        {
            try
            {
                Request.GetTokenUserId();
            } catch (Exception ex)
            {
                return RedirectToAction("Login", "Home");
            }

            var produtos = await _produtosService.GetAll(Request.GetToken());
            return View(produtos);
        }

        // GET: Produtos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            try
            {
                Request.GetTokenUserId();
            }
            catch (Exception ex)
            {
                return RedirectToAction("Login", "Home");
            }

            if (id == null)
            {
                return NotFound();
            }

            var produto = await _produtosService.GetById(id.Value, Request.GetToken());

            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // GET: Produtos/Create
        public IActionResult Create()
        {
            try
            {
                Request.GetTokenUserId();
            }
            catch (Exception ex)
            {
                return RedirectToAction("Login", "Home");
            }

            return View();
        }

        // POST: Produtos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,Preco,Status")] Produto produto)
        {
            if (ModelState.IsValid)
            {

                var sucesso = await _produtosService.Create(produto, Request.GetTokenUserId(), Request.GetToken());

                if (sucesso)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    // Tratar falha ao criar
                }
            }

            return View(produto);
        }

        // Restante das ações...

        // GET: Produtos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            try
            {
                Request.GetTokenUserId();
            }
            catch (Exception ex)
            {
                return RedirectToAction("Login", "Home");
            }

            if (id == null)
            {
                return NotFound();
            }

            var produto = await _produtosService.GetById(id.Value, Request.GetToken());

            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // POST: Produtos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Preco,Status,IdUsuarioCadastro")] Produto produto)
        {
            try
            {
                Request.GetTokenUserId();
            }
            catch (Exception ex)
            {
                return RedirectToAction("Login", "Home");
            }

            if (id != produto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                var sucesso = await _produtosService.Update(id, produto, Request.GetTokenUserId(), Request.GetToken());

                if (sucesso)
                {
                    return RedirectToAction(nameof(Index));
                }
            }

            return View(produto);
        }

        // Restante das ações...

        // GET: Produtos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            try
            {
                Request.GetTokenUserId();
            }
            catch (Exception ex)
            {
                return RedirectToAction("Login", "Home");
            }

            if (id == null)
            {
                return NotFound();
            }

            var produto = await _produtosService.GetById(id.Value, Request.GetToken());

            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // POST: Produtos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                Request.GetTokenUserId();
            }
            catch (Exception ex)
            {
                return RedirectToAction("Login", "Home");
            }

            var sucesso = await _produtosService.Delete(id, Request.GetToken());

            return RedirectToAction(nameof(Index));
        }
    }
}
