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
    public partial class frmMensualidad : Form
    {
        public frmMensualidad()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }
        List<clAutomovil> ListaVerAutomovil = new List<clAutomovil>();
        private void frmMensualidad_Load(object sender, EventArgs e)
        {
            clTarifa objTarifa = new clTarifa();
            DataTable dtTarifa = new DataTable();
            dtTarifa = objTarifa.mtdMensualidades();
            cmbTipoServicio.DataSource = dtTarifa;
            cmbTipoServicio.DisplayMember = "TipoS";
            cmbTipoServicio.ValueMember = "IdTarifa";


            clPago objPago = new clPago();
            DataTable dtPago = new DataTable();
            dtPago = objPago.mtdMostrar();
            dgvPagos.DataSource = dtPago;
            clAutomovil objAutomovil = new clAutomovil();
            DataTable dtAuto = new DataTable();
            dtAuto = objAutomovil.mtdMostrar();
            dgvBuscar.DataSource = dtAuto;
        }

        private void btnRegistrarC_Click(object sender, EventArgs e)
        {
            bool incorrecto = false;
            clCliente objCliente = new clCliente();
            objCliente.Documento = txtDocumento.Text;
            objCliente.Nombres = txtNombre.Text;
            objCliente.Telefono = txtTelefono.Text;
            List<clCliente> Repetir = new List<clCliente>();
            Repetir = objCliente.mtdAutoCompletar();

            for (int i = 0; i < Repetir.Count; i++)
            {
                if (Repetir[i].Documento == txtDocumento.Text)
                {
                    MessageBox.Show("Este Cliente Ya Esta Registrado");

                    incorrecto = true;
                }
                else
                {
                    incorrecto = false;
                }
            }
            if (incorrecto == false)
            {
                int can = objCliente.mtdRegistrarCliente();
                if (can > 0)
                {
                    MessageBox.Show("Registrado");
                    frmMensualidad_Load(null, null);
                    txtDocumento.Clear();
                    txtNombre.Clear();
                    txtTelefono.Clear();
                    txtPlaca2.Focus();
                }
                else
                {
                    MessageBox.Show("ERORRRRRRRRRR");
                }

            }

        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            clCliente objCliente = new clCliente();
            List<clCliente> ListaCliente = new List<clCliente>();
            objCliente.Documento = txtDocumento.Text;
            ListaCliente = objCliente.mtdAutoCompletar();
            for (int i = 0; i < ListaCliente.Count; i++)
            {
                if (ListaCliente[i].Documento == txtDocumento.Text)
                {
                    int variable = ListaCliente[i].IdCliente;
                    lblId.Text = variable.ToString();
                    txtNombre.Text = ListaCliente[i].Nombres;
                    txtTelefono.Text = ListaCliente[i].Telefono;
                }

            }
        }

        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            clAutomovil objAutomovil = new clAutomovil();

            List<clAutomovil> ListaAutomovil = new List<clAutomovil>();
            objAutomovil.Placa = txtPlaca.Text;
            dgvBuscar.DataSource = objAutomovil.mtdMostrar();
            ListaAutomovil = objAutomovil.mtdAutoCompletarAutomovil();
            for (int i = 0; i < ListaAutomovil.Count; i++)
            {
                if (ListaAutomovil[i].Placa == txtPlaca.Text)
                {

                    cmbTipo.Text = ListaAutomovil[i].TipoV;
                    txtObservacion.Text = ListaAutomovil[i].Observaciones;
                }

            }
        }

        private void txtPlaca2_KeyPress(object sender, KeyPressEventArgs e)
        {
            clAutomovil objAutomovil = new clAutomovil();

            List<clAutomovil> lista = new List<clAutomovil>();
            objAutomovil.Placa = txtPlaca2.Text;

            lista = objAutomovil.mtdAutoCompletarAutomovil();
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Placa == txtPlaca2.Text)
                {
                    int variable = lista[i].IdAutomovil;
                    lblAutomovil.Text = variable.ToString();
                    txtPlaca3.Text = lista[i].Placa;
                    txtTipo.Text = lista[i].TipoV;
                    txtObservaciones.Text = lista[i].Observaciones;
                }

            }
        }

        private void btnRegistrarA_Click(object sender, EventArgs e)
        {
            bool incorrecto = false;
            clAutomovil objAutomovil = new clAutomovil();
            objAutomovil.Placa = txtPlaca.Text;
            List<clAutomovil> RepetirPlaca = new List<clAutomovil>();

            RepetirPlaca = objAutomovil.mtdAutoCompletarAutomovil();
            for (int i = 0; i < RepetirPlaca.Count; i++)
            {
                if (RepetirPlaca[i].Placa == txtPlaca.Text)
                {
                    MessageBox.Show("Este Automovil ya esta registrado");
                    incorrecto = true;
                }
                else
                {
                    incorrecto = false;
                }
            }
            if (incorrecto == false)
            {
                objAutomovil.Placa = txtPlaca.Text;
                objAutomovil.TipoV = cmbTipo.Text;
                objAutomovil.Observaciones = txtObservacion.Text;
                clCliente objCliente = new clCliente();
                int variable = Convert.ToInt32(lblId.Text);
                objAutomovil.IdCliente = variable;
                int can = objAutomovil.mtdRegistrarAutomovil(variable);
                if (can > 0)
                {
                    MessageBox.Show("Registrado");
                    frmMensualidad_Load(null, null);
                    tabControl1.SelectedTab = tabPagos;
                    txtPlaca.Clear();
                    cmbTipo.Text = null;
                    txtObservacion.Clear();

                }
                else
                {
                    MessageBox.Show("ERORRRRRRRRRR");
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTiempo.Text = DateTime.Now.ToString();
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            clTarifa objTarifa = new clTarifa();
            DataTable dtMensualidades = new DataTable();
            dtMensualidades = objTarifa.mtdMensualidades();
            for (int i = 0; i < dtMensualidades.Rows.Count; i++)
            {
                if (cmbTipoServicio.Text == Convert.ToString(dtMensualidades.Rows[i]["TipoS"]))
                {
                    label7.Text = Convert.ToString(dtMensualidades.Rows[i]["TipoVe"]);
                    label9.Text = Convert.ToString(dtMensualidades.Rows[i]["Valor"]);

                }


            }
            if (label7.Text == txtTipo.Text)
            {
                clPago objPagos = new clPago();
                int variable = Convert.ToInt32(lblAutomovil.Text);
                objPagos.IdAutomovil = variable;
                string fecha = lblTiempo.Text;
                objPagos.FechaPago = fecha;
                objPagos.Valor = label9.Text;

                int Variable2 = Convert.ToInt32(cmbTipoServicio.SelectedValue.ToString());
                objPagos.IdTarifa = Variable2;
                int cantidad = objPagos.mtdRegistrarPago(variable, Variable2);
                MessageBox.Show("Datos Registrados" + cantidad);
                frmMensualidad_Load(null, null);
                


            }
            else
            {
                MessageBox.Show("Ese Valor no corresponde a su tipo de Vehiculo");
            }
        }

        private void btnModificarC_Click(object sender, EventArgs e)
        {
            clCliente objCliente = new clCliente();
            objCliente.Documento = txtDocumento.Text;
            objCliente.Nombres = txtNombre.Text;
            objCliente.Telefono = txtTelefono.Text;
            int can = objCliente.mtdModificarCliente();
            if (can > 0)
            {

                MessageBox.Show("Modificado" + can);
                frmMensualidad_Load(null, null);
                txtDocumento.Clear();
                txtNombre.Clear();
                txtTelefono.Clear();

            }
            else
            {
                MessageBox.Show("ERORRRRRRRRRR");
            }
        }

        private void btnModificarA_Click(object sender, EventArgs e)
        {
            clAutomovil objAutomovil = new clAutomovil();
            objAutomovil.Placa = txtPlaca.Text;
            objAutomovil.TipoV = cmbTipo.Text;
            objAutomovil.Observaciones = txtObservacion.Text;

            int can = objAutomovil.mtdModificarAutomovil();
            if (can > 0)
            {
                MessageBox.Show("Modificado" + can);
                frmMensualidad_Load(null, null);
                txtPlaca.Clear();
                cmbTipo.Text = null;
                txtObservacion.Clear();

            }
            else
            {
                MessageBox.Show("Errorrrrrrrrrrrrrrr");
            }
        }

        private void btnEliminarC_Click(object sender, EventArgs e)
        {
            clCliente objCliente = new clCliente();
            objCliente.Documento = txtDocumento.Text;
            objCliente.Nombres = txtNombre.Text;
            objCliente.Telefono = txtTelefono.Text;
            int can = objCliente.mtdEliminarCliente();
            if (can > 0)
            {

                MessageBox.Show("Eliminado " + can);
                frmMensualidad_Load(null, null);
                txtDocumento.Clear();
                txtNombre.Clear();
                txtTelefono.Clear();
            }
            else
            {
                MessageBox.Show("ERORRRRRRRRRR");
            }
        }

        private void btnEliminarA_Click(object sender, EventArgs e)
        {
            clAutomovil objAutomovil = new clAutomovil();
            objAutomovil.Placa = txtPlaca.Text;
            objAutomovil.TipoV = cmbTipo.Text;
            objAutomovil.Observaciones = txtObservacion.Text;


            int can = objAutomovil.mtdEliminarAutomovil();
            if (can > 0)
            {
                MessageBox.Show("Eliminado" + can);
                frmMensualidad_Load(null, null);
                txtPlaca.Clear();
                cmbTipo.Text = null;
                txtObservacion.Clear();

            }
            else
            {
                MessageBox.Show("Errorrrrrrrrrrrrrrr");
            }
        }
    }
}
