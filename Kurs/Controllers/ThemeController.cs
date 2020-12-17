using Kurs.Data.Interfaces;
using Kurs.Data.Models;
using Kurs.Data.Repository;
using Kurs.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs.Controllers
{
    public class ThemeController : Controller
    {
        private readonly IThemes iThemes;
        private readonly IThemsLevel iThemesLevel;

        public ThemeController(IThemes themes, IThemsLevel themsLevel)
        {
            iThemes = themes;
            iThemesLevel = themsLevel;
        }
        public ViewResult Index(int id)
        {
            Theme theme = iThemes.getObjectTheme(id); 
            return View("/Views/Themes/Theme.cshtml",theme);
        }
    }
}
