using System;
using System.IO;
using System.Data.SQLite;
using Xamarin.Forms;
using Opdracht.iOS;

[assembly: Dependency(typeof(SQLiteDb))]

namespace Opdracht.iOS
{
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
			var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); 
            var path = Path.Combine(documentsPath, "MySQLite.db3");


            return new SQLiteAsyncConnection(path);
        }
    }
}

