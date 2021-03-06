﻿using Kurs.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs.Data.Interfaces
{
    public interface IThemes
    {
        IEnumerable<Theme> Themes { get;}
        Theme getObjectTheme(int id);
    }
}
