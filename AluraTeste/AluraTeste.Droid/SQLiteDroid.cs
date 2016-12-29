using SQLite;
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
            string applicationFolderPath = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Refeicao.db");
            // Create the folder path.
            System.IO.Directory.CreateDirectory(applicationFolderPath);

            string databaseFileName = System.IO.Path.Combine(applicationFolderPath, "Refeicao.db");
            //SQLite.SQLite3.Config(SQLite.SQLite3.ConfigOption.Serialized);
            var db = new SQLiteConnection(databaseFileName);

            //var documents = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //var path = Path.Combine(documents, "data", "data", fileName);

            return  new SQLiteConnection(databaseFileName);
        }
    }
}