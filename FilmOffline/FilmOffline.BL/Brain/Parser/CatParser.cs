using System;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using FilmOffline.DataBase.Misc;
using System.Text;
using xNet.Net;
using xNet.Text;

namespace FilmOffline.BL.Brain.Parser
{
    class CatParser
    {
        Film _dataFilm;
        string _linkToFilm;

        public Film GetParsedFilm
        {
            get
            {
                Requester();
                return _dataFilm;
            }
        }
        public string LinkToFilm
        {
            get { return _linkToFilm; }
            set { _linkToFilm = value; }
        }

        public CatParser(string linkToFilm)
        {
            _dataFilm = new Film();
            _linkToFilm = linkToFilm;
        }

        void Requester() {
            try
            {
                using (var request = new HttpRequest())
                {
                    request.UserAgent = HttpHelper.RandomUserAgent();
                    request.Cookies = new CookieDictionary();
                    request.CharacterSet = Encoding.GetEncoding(1251);
                    var response = request.Get(_linkToFilm).ToString();
                }
            }
            catch(Exception e)
            {
                //
            }
        }

        void ResponseParse(string inputText)
        {
            try
            {
                _dataFilm.FilmName = inputText.Substring("<h1> ", " (");
                _dataFilm.Director = inputText.Substring("Режиссер:</b> ", "<br"); 
                _dataFilm.Duration = inputText.Substring("Продолжительность:</b> ", "<br");
                _dataFilm.Quality = inputText.Substring("Качество:</b> ", "<br");
                _dataFilm.Year = Convert.ToInt32(inputText.Substring("Год выпуска:</b> ", "<br"));
                _dataFilm.Rate = inputText.Substring("current-rating\" style=\"width:", "</li").Split('>')[1];
                _dataFilm.Note = inputText.Substring("<!--TEnd-->", "<br /><br /><b>");
                _dataFilm.Poster = new WebClient().DownloadData(inputText.Substring("<!--TBegin:", "|left-->"));
                _dataFilm.Actors = inputText.Substring("В ролях:</b> ", "</div>").Split(new []{", "}, StringSplitOptions.RemoveEmptyEntries);
                _dataFilm.Category = Regex.Replace(inputText.Substring("Жанр:</b> ", "<b>Качество:"), @"<[^>]+?>", "")
                    .Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries);
                _dataFilm.CodeFilm = Encoding.UTF8.GetString(Convert.FromBase64String(inputText.Substring("decode('", "')")));
            }
            catch { }
        }
    }
}
