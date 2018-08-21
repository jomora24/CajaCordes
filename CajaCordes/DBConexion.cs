using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CajaCordes
{
    class DBConexion
    {
        static MySqlConnection Conexion = new MySqlConnection();
        static string Servidor = "Server = localhost;";
        static string BD = "Database = dbcajacordes;";
        static string Usuario = "UID = root;";
        static string Clave = "Password = ;";

        string CadenaConexion = Servidor + BD + Usuario + Clave;

        static MySqlCommand Comando = new MySqlCommand();
        static MySqlDataAdapter Adaptador = new MySqlDataAdapter();
        public MySqlDataReader rst;

        public void CrearConexion()
        {
            try
            {
                Conexion.ConnectionString = CadenaConexion;
                Conexion.Open();
                //MessageBox.Show("Conexion Creada");
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la Conexion");
                throw;
            }
        }

        public void CerrarConexion()
        {
            Conexion.Close();
        }

        public void InsertRegistro(String nombre, String paterno, String materno, String parentesco, String codigo_asegurado){

            string strSQL = "INSERT INTO beneficiario VALUES(0,'" + nombre + "','" + paterno + "','" + materno + "','" + parentesco + "','" + codigo_asegurado + "' )";
            Comando.CommandText = strSQL;
            Comando.Connection = Conexion;
            Comando.ExecuteNonQuery();

        }

        public bool existeTitular(String codigo_asegurado)
        {

            try
            {
                string strSQL = "SELECT codigo_asegurado FROM titular WHERE codigo_asegurado = '" + codigo_asegurado + "'";
                Comando.CommandText = strSQL;
                Comando.Connection = Conexion;
                rst = Comando.ExecuteReader();
                return rst.HasRows;

            }
            catch (Exception)
            {
                MessageBox.Show("Error en la Conexion");
                throw;
            }



        }
    }
}
