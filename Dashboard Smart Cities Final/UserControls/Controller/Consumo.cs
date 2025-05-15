
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Consumo
{
    class ProgramConsumo
    {
        public static void CalcConsumo()
        {
            string connectionString = "server=127.0.0.1;port=3306;database=projeto12;uid=root;pwd=Janete10!;Allow User Variables=true;";
            Dictionary<int, double> consumoPorHora = new Dictionary<int, double>
        {
            { 1, 1.5 }, // Quarto 1
            { 2, 1.5 }, // Quarto 2
            { 3, 0.05 }, // Sala
            { 4, 3.0 }, // Cozinha
            { 5, 7.0 }  // Piscina
        };

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Busca todos os dados ordenados por sensor e horário
                string query = @"
                SELECT id_sensor, data_TimeStamp, hora_TimeStamp, movimento
                FROM DADOS_SENSOR
                ORDER BY id_sensor, data_TimeStamp, hora_TimeStamp";

                var cmd = new MySqlCommand(query, conn);
                var reader = cmd.ExecuteReader();

                var registros = new List<(int id_sensor, DateTime timestamp, bool movimento)>();

                while (reader.Read())
                {
                    int idSensor = reader.GetInt32("id_sensor");
                    DateTime data = reader.GetDateTime("data_TimeStamp");
                    TimeSpan hora = reader.GetTimeSpan("hora_TimeStamp");
                    bool movimento = reader.GetBoolean("movimento");

                    DateTime timestamp = data.Add(hora);
                    registros.Add((idSensor, timestamp, movimento));
                }

                reader.Close();

                // Processa consumo por par de movimento ON/OFF
                foreach (var grupo in registros.GroupBy(r => r.id_sensor))
                {
                    DateTime? entrada = null;
                    foreach (var registro in grupo)
                    {
                        if (registro.movimento && entrada == null)
                        {
                            entrada = registro.timestamp;
                        }
                        else if (!registro.movimento && entrada != null)
                        {
                            TimeSpan permanencia = registro.timestamp - entrada.Value;
                            double horas = permanencia.TotalHours;
                            if (horas > 0 && horas < 24)
                            {
                                double consumo = Math.Round(horas * consumoPorHora[registro.id_sensor], 2);

                                // Inserir na tabela CONSUMO
                                string insertQuery = @"
                                INSERT INTO CONSUMO (data, valor_kWh, id_sensor, id_usuario)
                                VALUES (@data, @valor, @sensor, (
                                    SELECT id_usuario FROM SENSOR WHERE id_sensor = @sensor
                                ))";
                                var insertCmd = new MySqlCommand(insertQuery, conn);
                                insertCmd.Parameters.AddWithValue("@data", entrada.Value.Date);
                                insertCmd.Parameters.AddWithValue("@valor", consumo);
                                insertCmd.Parameters.AddWithValue("@sensor", registro.id_sensor);
                                insertCmd.ExecuteNonQuery();
                            }

                            entrada = null;
                        }
                    }
                }

                Console.WriteLine("Consumo calculado e registrado com sucesso!");
            }
        }
    }
}