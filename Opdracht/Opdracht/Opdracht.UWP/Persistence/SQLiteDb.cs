using System.IO;
using Xamarin.Forms;
using Opdracht.Windows;
using Windows.Storage;

[assembly: Dependency(typeof(SQLiteDb))]

namespace Opdracht.Windows
{
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
			var documentsPath = ApplicationData.Current.LocalFolder.Path;
        	var path = Path.Combine(documentsPath, "MySQLite.db3");
        	return new SQLiteAsyncConnection(path);
        }
    }
}

