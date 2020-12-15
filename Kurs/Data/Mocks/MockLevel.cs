using Kurs.Data.Interfaces;
using Kurs.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs.Data.Mocks
{
    public class MockLevel : IThemsLevel
    {
        public IEnumerable<Level> GetAllLevels
        {
            get
            {
                return new List<Level>
                {
                    new Level {Name = "Новичок", description = "Этот уровень под силу любому. Если вы никогда не сталкивались с 3D графикой рекомендуем начинать с него"},
                    new Level {Name = "Продвинутый", description = "Вы неплохо понимаете основы и справляетесь с легкими задачами. Настало время улучшить свои навыки." }
                };
            }
        }
    }
}
