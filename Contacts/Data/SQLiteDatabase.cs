using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Contacts.Data
{
    public partial class SQLiteDatabase
    {
        private SQLiteAsyncConnection _database;

        public SQLiteAsyncConnection GetConnectionAsync()
        {
            if(_database == null)
            {
                return _database = new SQLiteAsyncConnection(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Azienda.db"));
            }
            return _database;
        }
    }
}
