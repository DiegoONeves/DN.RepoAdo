using DN.RepoAdo.Domain.DomainValidation;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DN.RepoAdo.Presentation.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        public BaseController()
        {

        }

        protected void AddModelError(ValidationResult result)
        {
            foreach (var item in result.Errors.Where(x => x.MessageCategory == MessageCategory.BusinessRule))
                ModelState.AddModelError("", item.Message);
        }
    }
}
