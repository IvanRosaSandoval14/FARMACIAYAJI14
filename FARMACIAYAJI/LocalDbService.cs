using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FARMACIAYAJI
{
    public class LocalDbService
    {
        private const string DB_NAME = "empleados.db3";
        private readonly SQLiteAsyncConnection _connection;

        public LocalDbService()
        {
            _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DB_NAME));
            _connection.CreateTableAsync<Empleado>();
        }

        public async Task<List<Empleado>> GetEmpleados() => await _connection.Table<Empleado>().ToListAsync();
        public async Task Create(Empleado empleado) => await _connection.InsertAsync(empleado);
        public async Task Update(Empleado empleado) => await _connection.UpdateAsync(empleado);
        public async Task Delete(Empleado empleado) => await _connection.DeleteAsync(empleado);
    }
}
