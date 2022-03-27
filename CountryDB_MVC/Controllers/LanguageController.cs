using CountryDB_MVC.Infrastructure.Repositories.Interface;
using CountryDB_MVC.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace CountryDB_MVC.Controllers
{
    public class LanguageController : Controller
    {
        private readonly ILanguageRepository _languageRepository;
        public LanguageController(ILanguageRepository languageRepository)
        {
            this._languageRepository = languageRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(LanguageCreateDTO model)
        {
            if (ModelState.IsValid)
            {
                Models.Entities.Language language = new Models.Entities.Language();
                language.LanguageName = model.LanguageName;

                _languageRepository.Create(language);

                return RedirectToAction("List");
            }
            else
            {
                return View(model);
            }
        }
    }
}
