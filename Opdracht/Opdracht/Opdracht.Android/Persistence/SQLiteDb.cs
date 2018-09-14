using System;
using System.IO;
using System.Data.SQLite;
using Xamarin.Forms;
using Opdracht.Droid;

[assembly: Dependency(typeof(SQLiteDb))]

namespace Opdracht.Droid
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

