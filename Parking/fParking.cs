using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{
    public partial class fParking : Form
    {
        clsBD oBaseDatos = new clsBD("..\\..\\..\\bdparking.mdb");
        clsVehiculo oVehiculo;

        DataSet dsMarcas;
        DataSet dsModelos;
        DataSet dsVehiculos;

        bool venimosDeSalida;

        // -------- para estado botones---------------
        string[] estados = new string[] { "inicio", "entrada", "saida" };
        Control[] controles;
        bool[,] comportamientoControles = new bool[,]
            {
                {true,true,false,false,false,false,false},
                {false,false,false,true,false,true,true},
                {false,false,true,false,true,true,true}
            };

        // -------- para ticket ----------------------
        int posicionVertical = 0;
        double TotalTicket = 1.5;

        Font fuenteG = new Font("Courier New", 12);
        Font fuenteN = new Font("Courier New", 10);
        Font fuenteP = new Font("Courier New", 8);
        Font fuenteMP = new Font("Courier New", 6);
        Font fuenteMParial = new Font("Arial", 6);
        // --------------------------------------------

        public fParking()
        {
            InitializeComponent();
            oBaseDatos.AbrirBD();
            controles = new Control[] { btEntrada, btSaida, gbxMatriculas, gbxDatos, btImprimir, btCancelar, btGardar };
        }

        private void estadoBotones(string estado)
        {
            int fila = Array.IndexOf(estados, estado);

            for (int i = 0; i < controles.GetLength(0); i++)
            {
                controles[i].Enabled = comportamientoControles[fila, i];
            }
        }

        private void limpiarCampos()
        {
            cbxVehiculosParking.Text = "";
            cbxMarca.Text = "";
            cbxModelo.Text = "";
            txbMatricula.Text = "";
        }

        private void fParking_Load(object sender, EventArgs e)
        {
            estadoBotones("inicio");
        }

        private void btSaida_Click(object sender, EventArgs e)
        {
            estadoBotones("saida");
            venimosDeSalida = true;
            cbxVehiculosParking.Items.Clear();

            oVehiculo = new clsVehiculo();
            dsVehiculos = oVehiculo.leerCochesParking(oBaseDatos);

            llenarComboVehiculos();
        }

        private void llenarComboVehiculos()
        {
            for (int i = 0; i < dsVehiculos.Tables[0].Rows.Count; i++)
            {
                cbxVehiculosParking.Items.Add(dsVehiculos.Tables[0].Rows[i][1]);
            }
        }

        private void cbxVehiculosParking_SelectedIndexChanged(object sender, EventArgs e)
        {
            oVehiculo.valorarPropiedades(dsVehiculos, cbxVehiculosParking.SelectedIndex);
            dsMarcas = oVehiculo.leerMarcas(oBaseDatos);
            dsModelos = oVehiculo.leerModelos(oBaseDatos);

            txbMatricula.Text = oVehiculo.matricula;

            llenarComboMarcas();
            ponerMarcaCocheSeleccionado();

            llenarComboModelos();
            ponerModeloCocheSeleccionado();
        }

        private void llenarComboMarcas()
        {
            cbxMarca.Items.Clear();

            for (int i = 0; i < dsMarcas.Tables[0].Rows.Count; i++)
            {
                cbxMarca.Items.Add(Convert.ToString(dsMarcas.Tables[0].Rows[i][1]));
            }
        }

        private void ponerMarcaCocheSeleccionado()
        {
            for (int i = 0; i < dsMarcas.Tables[0].Rows.Count; i++)
            {
                if (oVehiculo.idMarca.Equals(dsMarcas.Tables[0].Rows[i][0]))
                {
                    cbxMarca.SelectedIndex = i;
                    break;
                }
            }
        }

        private void llenarComboModelos()
        {
            cbxModelo.Items.Clear();

            for (int i = 0; i < dsModelos.Tables[0].Rows.Count; i++)
            {
                cbxModelo.Items.Add(Convert.ToString(dsModelos.Tables[0].Rows[i][1]));
            }
        }

        private void ponerModeloCocheSeleccionado()
        {
            for (int i = 0; i < dsModelos.Tables[0].Rows.Count; i++)
            {
                if (oVehiculo.idModelo.Equals(dsModelos.Tables[0].Rows[i][0]))
                {
                    cbxModelo.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            estadoBotones("inicio");
        }

        private void btGardar_Click(object sender, EventArgs e)
        {
            if (venimosDeSalida)
            {
                oVehiculo.eliminarVehiculoParking(oBaseDatos);
                limpiarCampos();
                MessageBox.Show("Vehiculo sacado del parking", "Vehiculo eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                llenarComboMarcas();
                estadoBotones("inicio");
            }
            else
            {
                ponerDatosVehiculo();

                oVehiculo.gardarVehiculoParking(oBaseDatos);
                limpiarCampos();
                MessageBox.Show("Vehiculo aparcado en el parking", "Vehiculo guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                estadoBotones("inicio");
            }
        }

        private void ponerDatosVehiculo()
        {
            oVehiculo.matricula = txbMatricula.Text;
            oVehiculo.marca = cbxMarca.SelectedItem.ToString();
            oVehiculo.modelo = cbxModelo.SelectedItem.ToString();

            for (int i = 0; i < dsModelos.Tables[0].Rows.Count; i++)
            {
                if (cbxModelo.SelectedItem.Equals(dsModelos.Tables[0].Rows[i][1]))
                {
                    oVehiculo.idModelo = Convert.ToInt32(dsModelos.Tables[0].Rows[i][0]);
                    break;
                }
            }
        }

        private void btEntrada_Click(object sender, EventArgs e)
        {
            estadoBotones("entrada");
            venimosDeSalida = false;
            oVehiculo = new clsVehiculo();

            dsMarcas = oVehiculo.leerMarcas(oBaseDatos);

            llenarComboMarcas();
        }

        private void cbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxModelo.Items.Clear();

            PonerIDDeMarcaSeleccionada();

            dsModelos = oVehiculo.leerModelos(oBaseDatos);
            PonerModeloSeleccionado();
        }

        private void PonerModeloSeleccionado()
        {
            for (int i = 0; i < dsModelos.Tables[0].Rows.Count; i++)
            {
                if (oVehiculo.idMarca.Equals(dsModelos.Tables[0].Rows[i][2]))
                {
                    cbxModelo.Items.Add(Convert.ToString(dsModelos.Tables[0].Rows[i][1]));
                }
            }
        }

        private void PonerIDDeMarcaSeleccionada()
        {
            for (int i = 0; i < dsMarcas.Tables[0].Rows.Count; i++)
            {
                if (cbxMarca.SelectedItem.Equals(dsMarcas.Tables[0].Rows[i][1]))
                {
                    oVehiculo.idMarca = Convert.ToInt32(dsMarcas.Tables[0].Rows[i][0]);
                    break;
                }
            }
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            vistaPrevia.Document = documentoImprimir;
            vistaPrevia.ShowDialog();
        }

        private void contenidoPagina(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string cadenaGuiones = "_".PadRight(50, '_');

            //cabeceira de ticket
            e.Graphics.DrawString("         P A R K I N G", fuenteN, Brushes.Black, 10, 10, new StringFormat());
            e.Graphics.DrawString("          -----------", fuenteN, Brushes.Black, 10, 20, new StringFormat());
            e.Graphics.DrawString("         piringalla s.l.", fuenteN, Brushes.Black, 10, 45, new StringFormat());
            e.Graphics.DrawString("         nif A270000000", fuenteN, Brushes.Black, 10, 60, new StringFormat());
            e.Graphics.DrawString("       Angelo Colocci s/n", fuenteN, Brushes.Black, 10, 75, new StringFormat());
            e.Graphics.DrawString("           27001 LUGO", fuenteN, Brushes.Black, 10, 90, new StringFormat());


            e.Graphics.DrawString(Convert.ToString(DateTime.Now), fuenteP, Brushes.Black, 10, 115, new StringFormat());

            e.Graphics.DrawString(cadenaGuiones, fuenteMP, Brushes.Black, 10, 140, new StringFormat());
            posicionVertical = 160;


            // detalle
            string lMatricula = Convert.ToString(oVehiculo.matricula);
            string lMarca = Convert.ToString(oVehiculo.marca);
            string lModelo = Convert.ToString(oVehiculo.modelo);

            e.Graphics.DrawString(lMatricula, fuenteMP, Brushes.Black, 10, posicionVertical, new StringFormat());
            e.Graphics.DrawString(lMarca, fuenteMP, Brushes.Black, 10, posicionVertical + 10, new StringFormat());
            e.Graphics.DrawString(lModelo, fuenteMP, Brushes.Black, 10, posicionVertical + 20, new StringFormat());

            // pe de ticket

            posicionVertical = 220;

            e.Graphics.DrawString(cadenaGuiones, fuenteMP, Brushes.Black, 10, posicionVertical, new StringFormat());
            posicionVertical += 15;
            e.Graphics.DrawString("total...", fuenteG, Brushes.Black, 90, posicionVertical, new StringFormat());
            e.Graphics.DrawString(string.Format("{0:###,##0.00}", TotalTicket), fuenteG, Brushes.Black, 180, posicionVertical, new StringFormat());
            posicionVertical += 40;
            e.Graphics.DrawString("   gracias pola súa visita", fuenteN, Brushes.Black, 20, posicionVertical, new StringFormat());
        }

    }
}
