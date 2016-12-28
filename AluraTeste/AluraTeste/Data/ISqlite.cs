using SQLite;

namespace AluraTeste.Data
{
    public interface ISqlite
    {
        SQLiteConnection GetConnection();
    }
}
