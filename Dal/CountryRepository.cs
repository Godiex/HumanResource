using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Dal
{
    public class CountryRepository
    {
        
        public void Agregar(string nombre)
        {
            using SqlConnection conexion = new SqlConnection(CadenaConexion.VALOR);
            conexion.Open();
            using SqlCommand cmd = new SqlCommand("INSERT INTO Country (Nombre) VALUES (@Nombre)", conexion);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public List<Departamento> Consultar()
        {
            using SqlConnection conexion = new SqlConnection(CadenaConexion.VALOR);
            List<Departamento> departamentos = new List<Departamento>();
            conexion.Open();
            string consulta = "SELECT Id, Nombre FROM Departamentos";

            using SqlCommand cmd = new SqlCommand(consulta, conexion);
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                string nombre = reader["Nombre"].ToString();
                Departamento departamento = new Departamento(id, nombre);
                departamentos.Add(departamento);
            }

            return departamentos;
        }

        public void Actualizar(Departamento departamentoActualizado)
        {
            using SqlConnection conexion = new SqlConnection(CadenaConexion.VALOR);
            conexion.Open();
            string consulta = "UPDATE Departamentos SET Nombre = @NuevoNombre WHERE Id = @Id";

            using SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.Parameters.AddWithValue("@Id", departamentoActualizado.Id);
            cmd.Parameters.AddWithValue("@NuevoNombre", departamentoActualizado.Nombre);
            int filasActualizadas = cmd.ExecuteNonQuery();

            if (filasActualizadas == 0)
            {
                throw new Exception("Departamento no existe");
            }
        }
        
    }
}
