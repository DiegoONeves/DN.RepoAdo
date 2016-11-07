using DN.RepoAdo.Application.Commands;
using DN.RepoAdo.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DN.RepoAdo.Presentation.Web.Controllers
{
    public class StoreController : BaseController
    {
        private readonly IStoreAppService storeAppService;
        public StoreController(IStoreAppService storeAppService)
        {
            this.storeAppService = storeAppService;
        }

        public IActionResult Index()
        {
            return View(storeAppService.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Create(CreatedStore command)
        {
            var result = storeAppService.CreateNewStore(command);

            if (!result.IsValid)
            {
                AddModelError(result);
                return View(command);
            }

            return RedirectToAction("Index");
        }
    }
}
