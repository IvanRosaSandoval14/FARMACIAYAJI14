using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;


namespace FARMACIAYAJI
{
    public class DatabaseService
    {
        private readonly SQLiteAsyncConnection _database;

        public DatabaseService()
        {
            var dbPath = Path.Combine(FileSystem.AppDataDirectory, "FARMACIAYAJI.db3");
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Usuario>().Wait();
            _database.CreateTableAsync<Producto>().Wait();
            _database.CreateTableAsync<Factura>().Wait();
          
        }



        public Task<List<Usuario>> GetUsersAsync()
        {
            return _database.Table<Usuario>().ToListAsync();
        }

        public Task<int> SaveUserAsync(Usuario usuario)
        {
            return _database.InsertAsync(usuario);
        }

        public Task<Usuario> GetUserByEmailAsync(string email)
        {
            return _database.Table<Usuario>().Where(u => u.Correo == email).FirstOrDefaultAsync();
        }


        public Task<int> SaveFacturaAsync(Factura factura)
        {
            return _database.InsertAsync(factura);
        }

        public Task<int> SaveProductoAsync(Producto producto)
        {
            return _database.InsertAsync(producto);
        }

        public Task<List<Producto>> GetProductosAsync()
        {
            return _database.Table<Producto>().ToListAsync();
        }

      

       


    }
}
