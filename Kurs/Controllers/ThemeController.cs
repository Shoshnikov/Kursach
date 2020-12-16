using Kurs.Data.Interfaces;
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
        public ViewResult Index()
        {
            return View("/Views/Themes/Theme.cshtml");
        }
    }
}
