using System;
using System.Collections.Generic;
using System.Linq;
using FilmOffline.DataBase.Providers.Interfaces;
using FilmOffline.BL.Config;


namespace FilmOffline.DataBase.Providers
{
    class LogProvider:MainProvider,ILogProvider<List<string>>
    {
        public List<string> GetLogs()
        {
            return DB.Log.Select(s => DB.Log.DateColumn + " " + DB.Log.EventColumn).ToList();
        }

        public void AddLog(string evenT)
        {
            DB.Log.AddLogRow(DateTime.Now, evenT);
            
        }
    }
}
