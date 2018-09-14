using System;

namespace Opdracht
{
    public class SQLiteAsyncConnection
    {
        private string path;

        public SQLiteAsyncConnection(string path)
        {
            this.path = path;
        }

        internal void CreateTableAsync<T>()
        {
            throw new NotImplementedException();
        }
    }
}