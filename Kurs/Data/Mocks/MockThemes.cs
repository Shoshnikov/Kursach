using Kurs.Data.Interfaces;
using Kurs.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs.Data.Mocks
{
    public class MockThemes : IThemes
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
                    new Theme {name = "Анимация в Blender 2.90", shortDescription = "Все об анимации для начинающих", longDescription = "longDescription", img = "/img/anim.jpg", level = _themsLevel.GetAllLevels.First() },
                    new Theme {name = "Скульптинг и моделирование", shortDescription = "Все о скульптинге для начинающих и продвинутых пользователей", longDescription = "longDescription", img = "/img/sculpt.png", level = _themsLevel.GetAllLevels.First() },
                    new Theme {name = "Коллекции и моделирование", shortDescription = "Все о коллекциях для начинающих", longDescription = "longDescription", img = "/img/collections.png", level = _themsLevel.GetAllLevels.First() },
                    new Theme {name = "Симуляция жидкости", shortDescription = "Статья о создании реалистичной жидкости для знатоков Blender", longDescription = "longDescription", img = "/img/water.jpg", level = _themsLevel.GetAllLevels.First() },
                    new Theme {name = "Создание разлома", shortDescription = "Создание разломов для начинающих и продвинутых пользователей", longDescription = "longDescription", img = "/img/cracks.jpg", level = _themsLevel.GetAllLevels.First() },
                    new Theme {name = "Симуляция ткани", shortDescription = "Все о симуляции тканей для продвинутых пользователей", longDescription = "longDescription", img = "/img/cloth.jpg", level = _themsLevel.GetAllLevels.First() },
                    new Theme {name = "Создание реалистичных капель", shortDescription = "Статья о создании реалистичных капель для продвинутых пользователей", longDescription = "longDescription", img = "/img/raindrop.jpg", level = _themsLevel.GetAllLevels.First() },
                    new Theme {name = "Создание реалистичного меха", shortDescription = "Все о создании реалистичного меха для продвинутых пользователей", longDescription = "longDescription", img = "/img/fur.jpg", level = _themsLevel.GetAllLevels.First() },
                    new Theme {name = "Создание бесшовного мэша", shortDescription = "Статья о создании бесшовного мэша для начинающих", longDescription = "longDescription", img = "/img/seamless.png", level = _themsLevel.GetAllLevels.First() }
                };
            }
        }

        public Theme getObjectTheme(int id)
        {
            throw new NotImplementedException();
        }
    }
}
