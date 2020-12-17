using Kurs.Data.Interfaces;
using Kurs.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs.Data.Repository
{
    public class ThemeRepository : IThemes
    {
        private readonly AppDBContent content;

        public ThemeRepository(AppDBContent appDBContent)
        {
            content = appDBContent;
        }

        public IEnumerable<Theme> Themes => content.Theme.Include(c => c.level);

        public Theme getObjectTheme(int id) => content.Theme.FirstOrDefault(p => p.id == id);

        public IEnumerable<Theme> Master => content.Theme.Include(c => c.levelID == 3);
    }
}
