using Kurs.Data.Interfaces;
using Kurs.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs.Data.Mocks
{
    public class MockThemes
    {
        private readonly IThemsLevel _themsLevel = new MockLevel();
        public IEnumerable<Theme> Themes 
        {
            get
            {
                return new List<Theme>
                {
                    new Theme {name = "Blender 2.91", shortDescription = "Новая версия Blender", longDescription = "longDescription", img = "/img/2.91.jpg", level = _themsLevel.GetAllLevels.First() },
                    new Theme {name = "Hard-Surface моделирование в Blender", shortDescription = "Создание твердых поверхностей", longDescription = "longDescription", img = "/img/hardsrfc.jpg", level = _themsLevel.GetAllLevels.First() },
                    new Theme {name = "Blender 2.90", shortDescription = "Новая версия Blender", longDescription = "longDescription", img = "/img/2.90.jpg", level = _themsLevel.GetAllLevels.First() },
                    new Theme {name = "Анимация в Blender 2.90", shortDescription = "Все об анимации для начинающих", longDescription = "longDescription", img = "/img/anim.jpg", level = _themsLevel.GetAllLevels.First() }
                };
            }
        }

        public Theme getObjectTheme(int id)
        {
            throw new NotImplementedException();
        }
    }
}
