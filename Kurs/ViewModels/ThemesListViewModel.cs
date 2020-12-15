using Kurs.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs.ViewModels
{
    public class ThemesListViewModel
    {
        public IEnumerable<Theme> themes { get; set; }

        public string currentLevel { get; set; }

    }
}
