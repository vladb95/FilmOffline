using System;

namespace FilmOffline.DataBase.Providers.Interfaces
{
    interface ILogProvider<T>
    {
        T GetLogs();
        void AddLog(string evenT);
    }
}
