using FilmOffline.DataBase.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FilmOffline
{
    public class MainProvider
    {
        protected LocalFilmData _dataBase;

        protected LocalFilmData DB
        {
            get { return _dataBase??(new LocalFilmData()); }
            set { _dataBase = value; }
        }
    }
}
