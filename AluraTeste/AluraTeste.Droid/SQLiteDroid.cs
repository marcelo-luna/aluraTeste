using System;
using SQLite;
using System.IO;
using AluraTeste.Data;
using Xamarin.Forms;
using AluraTeste.Droid;

[assembly : Dependency( typeof(SQLiteDroid))]
namespace AluraTeste.Droid
{
    public class SQLiteDroid : ISqlite
    {
        public SQLiteDroid()
        {
        }

        public SQLiteConnection GetConnection()
        {
            var fileName = "Refeicoes.db3";
            var documents = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documents, "..", "Library", fileName);

            return  new SQLiteConnection(path);
        }
    }
}