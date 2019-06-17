using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parking
{
    public class clsBD
    {
        System.Data.OleDb.OleDbConnection conexion;

        // pasamos al constructor el nombre de la BD que queremos usar
        public clsBD(string nomeBD)
        { 
            string CadenaConexion=string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='{0}'",nomeBD);
            conexion = new System.Data.OleDb.OleDbConnection(CadenaConexion);
        }

        // Abrir BD
        public void AbrirBD()
        {
            try 
            {
                if (conexion.State != System.Data.ConnectionState.Open)
                { 
                    conexion.Open();
                    MessageBox.Show("BD Abierta");
                }
            }
            catch (System.Data.OleDb.OleDbException errBD)
            {
                MessageBox.Show(errBD.Message, "Erro intentado abrir BD");
            }
        }
        // Cerrar BD
        public void CerrarBD()
        {
            try
            {
                if (conexion.State != System.Data.ConnectionState.Closed)
                {
                    conexion.Close();
                    MessageBox.Show("BD Cerrada");
                }
            }
            catch (System.Data.OleDb.OleDbException errBD)
            {
                MessageBox.Show(errBD.Message, "Erro intentado cerrar BD");
            }
        }

        // Operaciones NONQUERY (no select)

        public void executeNONQUERY(string CadenaSQL)
        {
            try 
            {
                System.Data.OleDb.OleDbCommand comando=new System.Data.OleDb.OleDbCommand(CadenaSQL,conexion);
                comando.ExecuteNonQuery();
            }
            catch(System.Data.OleDb.OleDbException errBD)
            {
                MessageBox.Show(errBD.Message, "Error nunha operación NONQUERY");
            }

        }

        public System.Data.DataSet executeSELECT(string CadenaSQL)
        {
            System.Data.DataSet DS = new System.Data.DataSet();
            try
            {
                System.Data.OleDb.OleDbDataAdapter DA = new System.Data.OleDb.OleDbDataAdapter(CadenaSQL, conexion);
                DA.Fill(DS);
            }
            catch (System.Data.OleDb.OleDbException errBD)
            {
                MessageBox.Show(errBD.Message, "Erro consultando BD");
            }
            return DS;
        }

        public int executeScalar(string CadenaSQL)
        {
            int resultado = 0;
            try
            {
                System.Data.OleDb.OleDbCommand comando = new System.Data.OleDb.OleDbCommand(CadenaSQL, conexion);
                resultado = Convert.ToInt32(comando.ExecuteScalar());
            }
            catch (System.Data.OleDb.OleDbException errBD)
            {
                MessageBox.Show(errBD.Message, "Erro nunha operación SCALAR");
            }

            return resultado;
        }
    }
}
