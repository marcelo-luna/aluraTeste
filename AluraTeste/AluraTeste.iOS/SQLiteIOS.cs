using AluraTeste.Data;
using AluraTeste.iOS;
using Xamarin.Forms;
using SQLite;
using System.IO;

[assembly: Dependency(typeof(SQLiteIOS))]
namespace AluraTeste.iOS
{
    public class SQLiteIOS : ISqlite
    {
        public SQLiteIOS()
        {
        }

        public SQLiteConnection GetConnection()
        {
            /*string applicationFolderPath = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Refeicao.db");
            // Create the folder path.
            System.IO.Directory.CreateDirectory(applicationFolderPath);

            string databaseFileName = System.IO.Path.Combine(applicationFolderPath, "Refeicao.db");
            //SQLite.SQLite3.Config(SQLite.SQLite3.ConfigOption.Serialized);
            var db = new SQLiteConnection(databaseFileName);

            //var documents = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //var path = Path.Combine(documents, "data", "data", fileName);

            return new SQLiteConnection(databaseFileName);
            */
            var filename = "Refeicoes.db";

            string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(folder, "..", "Library", filename);
            var connection = new SQLiteConnection(path);

            return connection;
        }
    }
}
