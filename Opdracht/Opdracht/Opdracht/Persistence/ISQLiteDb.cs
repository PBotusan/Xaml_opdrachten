namespace Opdracht
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}

