using FilmOffline.DataBase.Base;
using FilmOffline.DataBase.Providers.Interfaces;
using System;
using System.Collections.Generic;
using FilmOffline.DataBase.Misc;

namespace FilmOffline.DataBase.Providers
{
    public class FilmProvider:MainProvider,IFilmProvider<List<Film>>
    {
        public void AddFilm(Film filmToAdd)
        {
            //DB.Film.AddFilmRow(filmToAdd.FilmName, DB.Category.Where, filmToAdd.Year, DB.Director.Where, DB.Country.Where, filmToAdd.Poster, filmToAdd.CodeFilm, DB.Rate.Where, DB.Quality.Where, filmToAdd.Note, filmToAdd.Duration);
           // DB.Film.AddFilmRow(filmToAdd);
        }

        public List<Film> GetAllFilms()
        {
            return new List<Film>();
        }

        public List<Film> GetFilms(Func<LocalFilmData,List<Film>> func)
        {
            return func(DB);
        }
    }
}
