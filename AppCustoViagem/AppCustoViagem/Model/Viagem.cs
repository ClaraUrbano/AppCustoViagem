using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AppCustoViagem.Model
{
    public class Viagem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public double Distancia { get; set; }
        public double Consumo { get; set; }
        public double PrecoCombustivel { get; set; }
    }
}
