using System;
using System.Collections.Generic;

namespace FilmOffline.BL.Config
{
    public class Film
    {
        public string FilmName { get; set; }
        public string Duration { get; set; }
        public string Category { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public string CodeFilm { get; set; }
        public byte[] Poster { get; set; }
        public string Rate { get; set; }
        public string Note { get; set; }
        public string Quality { get; set; }
        public List<string> Actors { get; set; }
    }
}
