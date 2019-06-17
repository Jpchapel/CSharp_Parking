using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    class clsVehiculo
    {
        #region "p privadas"
        private int _id;
        private string _matricula;
        private int _idMarca;
        private int _idModelo;

        private string _marca;
        private string _modelo;

        #endregion
        #region "p publicas"
        public int id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string matricula
        {
            get
            {
                return _matricula;
            }

            set
            {
                _matricula = value;
            }
        }

        public int idMarca
        {
            get
            {
                return _idMarca;
            }

            set
            {
                _idMarca = value;
            }
        }

        public int idModelo
        {
            get
            {
                return _idModelo;
            }

            set
            {
                _idModelo = value;
            }
        }

        public string marca
        {
            get
            {
                return _marca;
            }

            set
            {
                _marca = value;
            }
        }

        public string modelo
        {
            get
            {
                return _modelo;
            }

            set
            {
                _modelo = value;
            }
        }

        
        #endregion

        public System.Data.DataSet leerMarcas(clsBD oBD)
        {
            string cadenaSQL;
            cadenaSQL = "select * from Marca";
            return oBD.executeSELECT(cadenaSQL);
        }

        public System.Data.DataSet leerModelos(clsBD oBD)
        {
            string cadenaSQL;
            cadenaSQL = string.Format("select * from Modelo where idMarca={0}",this.idMarca);
            return oBD.executeSELECT(cadenaSQL);
        }
      
        public System.Data.DataSet leerCochesParking(clsBD oBD)
        {
            string cadenaSQL;
            cadenaSQL = string.Format("select * from Parking");
            return oBD.executeSELECT(cadenaSQL);
        }

        public void valorarPropiedades(System.Data.DataSet ds, int indice)
        {
            this.id = (int)ds.Tables[0].Rows[indice][0];
            this.matricula = (string)ds.Tables[0].Rows[indice][1];
            this.idMarca = (int)ds.Tables[0].Rows[indice][2];
            this.idModelo = (int)ds.Tables[0].Rows[indice][3];
        }

        public void gardarVehiculoParking(clsBD oBD)
        {
            string cadenaSQL;
            cadenaSQL = string.Format(@"insert into Parking(matricula,idMarca,idModelo)
                                      values ('{0}',{1},{2})",this.matricula,this.idMarca,this.idModelo);
            oBD.executeNONQUERY(cadenaSQL);
        }

        public void eliminarVehiculoParking(clsBD oBD)
        {
            string cadenaSQL;
            cadenaSQL = string.Format("delete from Parking where id={0}", this.id);
            oBD.executeNONQUERY(cadenaSQL);
        }
    }
}
