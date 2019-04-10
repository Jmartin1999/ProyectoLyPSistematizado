using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLyPSistematizadoReal.Datos;

namespace AppLyPSistematizadoReal.Vista
{
    public partial class FrmLavadero : Form
    {
        public FrmLavadero()
        {
            InitializeComponent();
        }


        List<VclLavadero> listadatos = new List<VclLavadero>();

        private void FrmLavadero_Load(object sender, EventArgs e)
        {
            VclLavadero lavadero = new VclLavadero();
            listadatos = lavadero.mtdListar();
            dgvDatos.DataSource = lavadero.mtdListar();

            // combos
            clPersona empleado = new clPersona();
            DataTable dtempleado = new DataTable();
            dtempleado = empleado.mtdListar();
            cmbPersona.DataSource = dtempleado;
            cmbPersona.DisplayMember = "NombreP";
            cmbPersona.ValueMember = "IdPersona";



            VclLavadero lavadero3 = new VclLavadero();
            listadatos = lavadero3.mtdListar();
            dgvDatos.DataSource = lavadero.mtdListar();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text;
            string tipovehiculo = "";
            string valor = "";
            for (int i = 0; i < listadatos.Count; i++)
            {
                if (listadatos[i].PLACA == placa)
                {
                    tipovehiculo = listadatos[i].TIPOVEHICULO;
                    valor = listadatos[i].VALOR;
                }
            }
            if (tipovehiculo == "CARRO")
            {
            }
            else if (tipovehiculo == "MOTO")
            {
            }
            else if (tipovehiculo == "BICICLETA")
            {
            }
            txtServicio.Text = valor;
        }

        private void btnServicio_Click(object sender, EventArgs e)
        {
            //REGISTRO SERVICIO
            VclLavadero servicio = new VclLavadero();
            servicio.VALOR = txtServicio.Text;
            servicio.IdAutomovil = lblAutomovil.Text;
            servicio.IdPersona = Convert.ToInt32(cmbPersona.SelectedValue);
            servicio.IdTarifa = lblidServicio.Text;
            int CONTT = servicio.mtdregistrar();
            if (CONTT > 0)
            {
                MessageBox.Show("servicio Registrado");
                VclLavadero Objservicio = new VclLavadero();
                dgvDatos.DataSource = Objservicio.mtdListar();
            }
            else
            {
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtPlaca.Clear();
            txtServicio.Clear();

            VclLavadero Objservicio = new VclLavadero();
            dgvDatos.DataSource = Objservicio.mtdListar();
        }

        private void btnautomovil_Click(object sender, EventArgs e)
        {
            VclLavadero lavadero = new VclLavadero();
            lavadero.PLACA = txtPlaca.Text;
            lavadero.TIPOVEHICULO = cmbTipoVehiculo.Text;
            //string tipovehiculo = "";
            //if (tipovehiculo == "carro")
            //{
            //    rbCarro.Checked = true;
            //}
            //else if (tipovehiculo == "moto")
            //{
            //    rbMoto.Checked = true;
            //}
            //else if (tipovehiculo == "bicicleta")
            //{
            //    rbBicicleta.Checked = true;
            //}
            //lavadero.TIPOVEHICULO = tipovehiculo;

            int canttt = lavadero.mtdregistrar();
            if (canttt > 0)
            {
                MessageBox.Show("Datos Registrados");
                VclLavadero Objpersona = new VclLavadero();
                dgvDatos.DataSource = Objpersona.mtdListar();
            }
            else
            {
                MessageBox.Show("Datos no Registrados");
            }

            // id de Aautomovil
            VclLavadero objCliente = new VclLavadero();
            int variable = objCliente.mtdasignarvehi();
            lblAutomovil.Text = variable.ToString();

            

            // valor del servicio
            if (lblServicio.Text == "LAVADO1")
            {
                txtServicio.Text = "30000";
            }
            else if (lblServicio.Text == "LAVADO2")
            {
                txtServicio.Text = "1500";
            }
            else if (lblServicio.Text == "LAVADO3")
            {
                txtServicio.Text = "5000";
            }

            // iD de tarifa
            if (lblServicio.Text == "LAVADO1")
            {
                lblidServicio.Text = "1";
            }
            else if (lblServicio.Text == "LAVADO2")
            {
                lblidServicio.Text = "4";
            }
            else if (lblServicio.Text == "LAVADO3")
            {
                lblidServicio.Text = "7";
            }
        }

        private void cmbTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoVehiculo.Text == "CARRO")
            {
                lblServicio.Text = "LAVADO1";
            }
            else if (lblServicio.Text == "MOTO")
            {
                lblServicio.Text = "LAVADO2";
            }
            else if (lblServicio.Text == "BICICLETA")
            {
                lblServicio.Text = "LAVADO3";
            }
        }
    }
}
