using System;
using System.Collections.Generic;
using System.Text;

using SQLite;
using AppCustoViagem.Model;
using System.Threading.Tasks;

namespace AppCustoViagem.Helper
{
    public class SQLiteDatabaseHelper
    {
        readonly SQLiteAsyncConnection _connection;

        public SQLiteDatabaseHelper (string path)
        {
            _connection = new SQLiteAsyncConnection (path);
            _connection.CreateTableAsync<Viagem>().Wait();
        }

        public Task<int> Save(Viagem t)
        {
            return _connection.InsertAsync(t);
        }

        public Task<List<Viagem>> GetAllRows()
        {
            return _connection.Table<Viagem>().ToListAsync();
        }

        public Task<int> Delete(int id)
        {
            return _connection.Table<Viagem>().DeleteAsync(i => i.Id == id);
        }

        public Task<List<Viagem>> Update(Viagem t)
        {
            string sql = "UPDATE viagem SET" +
                         "Origem=?, Destino=?, Distancia=?, Consumo=?, PrecoCombustivel=?" +
                         "WHERE Id=?";

            return _connection.QueryAsync<Viagem>(sql,
                t.Origem, t.Destino, t.Distancia, t.Consumo, t.PrecoCombustivel, t.Id);
        }

        public Task<List<Viagem>> Search(String q)
        {
            string sql = "SELECT * FROM Viagem WHERE Descricao LIKE '%" + q + "%'";

            return _connection.QueryAsync<Viagem>(sql);
        }
    }
}
