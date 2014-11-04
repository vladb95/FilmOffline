using System;
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

        void RespnseParse(string inputText)
        {
            try
            {
                //_dataFilm= 
                return;
            }
            catch { }
        }
    }
}
