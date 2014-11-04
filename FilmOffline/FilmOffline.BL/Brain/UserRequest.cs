using System;
using FilmOffline.BL.Config;
using System.Collections.Generic;
using FilmOffline.DataBase.Misc;
using FilmOffline.DataBase.Providers;


namespace FilmOffline.BL.Brain
{
    class UserRequest
    {
        List<Film> _respons = new List<Film>();
        public List<Film> Response { get { return _respons; } }

        public UserRequest(string requestText, RequestType type)
            : this(new Request()
            {
                RequestString = requestText,
                Type = type
            }) { }

        public UserRequest(Request requestObject)
        {
            RequestSender(requestObject);
        }

        void RequestSender(Request reqObject)
        {
            var filmProv = new FilmProvider();
            /**_respons.AddRange(()=>
            {
                switch (reqObject.Type)
                {
                    case RequestType.All: return filmProv.GetAllFilms();
                    case RequestType.FilmName: return filmProv.GetFilms(d => { return new List<Film>(); });
                    
                }
            });*/
        }
    }
}
