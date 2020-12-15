using Kurs.Data.Interfaces;
using Kurs.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs.Controllers
{
    public class ThemesController : Controller
    {
        private readonly IThemes iThemes;
        private readonly IThemsLevel iThemesLevel;

        public ThemesController(IThemes themes, IThemsLevel themsLevel)
        {
            iThemes = themes;
            iThemesLevel = themsLevel;
        }

        public ViewResult List()
        {
            ThemesListViewModel themesList = new ThemesListViewModel();
            themesList.themes = iThemes.Themes;
            themesList.currentLevel = "Начинающий";
            return View(themesList);
        }
    }
}
