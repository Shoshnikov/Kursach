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
                    
                };
            }
        }

        public Theme getObjectTheme(int id)
        {
            throw new NotImplementedException();
        }
    }
}
