using System.Collections.Generic;
using System.Linq;
using FilmOffline.DataBase.Base;
using FilmOffline.DataBase.Misc;
using System;

namespace FilmOffline.DataBase.Providers.Interfaces
{
    interface IFilmProvider<T>
    {
        void AddFilm(Film filmToAdd);
        T GetAllFilms();
        T GetFilms(Func<LocalFilmData,T> func);
    }
}
