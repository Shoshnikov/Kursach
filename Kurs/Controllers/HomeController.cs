using Kurs.Data.Interfaces;
using Kurs.Data.Models;
using Kurs.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs.Controllers
{
    public class HomeController : Controller
    {
        private readonly IThemes iThemes;
        private readonly IThemsLevel iThemesLevel;

        public HomeController(IThemes themes, IThemsLevel themsLevel)
        {
            iThemes = themes;
            iThemesLevel = themsLevel;
        }

        public ViewResult Index()
        {
            ThemesListViewModel themesList = new ThemesListViewModel();
            themesList.themes = iThemes.Themes;
            themesList.currentLevel = "Начинающий";
            return View(themesList);
        }

        public ViewResult MasterThemes(int levelID)
        {
            ThemesListViewModel themesList = new ThemesListViewModel();
            themesList.themes = ChooseThemes(levelID);
            return View("Index",themesList);
        }

        private List<Theme> ChooseThemes(int levelID)
        {
            List<Theme> list = new List<Theme>();
            foreach (Theme t in iThemes.Themes)
            {
                if (t.levelID == levelID)
                    list.Add(t);
            }
            return list;
        }
    }
}
