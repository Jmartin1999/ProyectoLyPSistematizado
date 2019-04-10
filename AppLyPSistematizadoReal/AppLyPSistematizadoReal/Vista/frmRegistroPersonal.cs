using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLyPSistematizadoReal.Datos;

namespace AppLyPSistematizadoReal.Vista
{
    public partial class frmRegistroPersonal : Form
    {
        public frmRegistroPersonal()
        {
            InitializeComponent();
        }
        List<clRegistroPersonal> listaPersonal = new List<clRegistroPersonal>();
        private void frmRegistroPersonal_Load(object sender, EventArgs e)
        {
            clRegistroPersonal objRegistro = new clRegistroPersonal();
            List<clRegistroPersonal> listapersonal = new List<clRegistroPersonal>();
            listapersonal = objRegistro.mtdListarPersona();
            dgvPersonal.DataSource = listapersonal;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool incorrecto = false;
            clRegistroPersonal objRegistro = new clRegistroPersonal();
            objRegistro.Documento = txtDocumento.Text;
            objRegistro.NombreP = txtNombres.Text;
            objRegistro.Direccion = txtDireccion.Text;
            objRegistro.Telefono = txtTelefono.Text;
            objRegistro.Correo = txtCorreo.Text;
            objRegistro.Contraseña = txtContraseña.Text;
            objRegistro.Rol = cmbRol.Text;
            List<clRegistroPersonal> Repetido = new List<clRegistroPersonal>();
            Repetido = objRegistro.mtdListarPersona();
            for (int i = 0; i < Repetido.Count; i++)
            {
                if (Repetido[i].Documento == txtDocumento.Text)
                {
                    MessageBox.Show("Este Empleado Ya esta registrado");
                    txtDocumento.Clear();
                    txtDocumento.Focus();
                    incorrecto = true;
                    break;

                }
                else
                {
                    incorrecto = false;
                }



            }
            if (incorrecto == false)
            {
                int can = objRegistro.mtdRegistrar();
                if (can > 0)
                {
                    MessageBox.Show("Registrado" + can);
                    txtDocumento.Clear();
                    txtNombres.Clear();
                    txtDireccion.Clear();
                    txtTelefono.Clear();
                    txtCorreo.Clear();
                    txtContraseña.Clear();
                    cmbRol.Text = null;
                    txtDocumento.Focus();

                }
                else
                {
                    MessageBox.Show("ERORRRRRRRRRR");

                }
            }
        }
        public static bool validaremail(string email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (System.Text.RegularExpressions.Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (validaremail(txtCorreo.Text))
            {

            }
            else
            {
                MessageBox.Show("Direccion de correo electronico no valida,el correo debe tener el formato : dominio@gmail.com," +
                    "porfavor seleccione un correo valido", "Validacion de correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCorreo.SelectAll();
                txtCorreo.Focus();
            }
        }
        public void mtdEnviar()
        {

            MailMessage objMensaje = new MailMessage();
            objMensaje.To.Add(txtCorreo.Text);
            objMensaje.From = new MailAddress("jonathan200045@gmail.com", "", System.Text.Encoding.UTF8);
            objMensaje.Subject = "Bienvenido Registro Exitoso";
            objMensaje.SubjectEncoding = System.Text.Encoding.UTF8;
            objMensaje.Body = "Documento" + "=" + txtDocumento.Text + "Nombres" + "=" + txtNombres.Text + "Direccion" + "=" + txtDireccion.Text + "Telefono" + "=" + txtTelefono.Text + "Correo" + "=" + txtCorreo.Text + "Contraseña" + "=" + txtContraseña.Text + "Rol" + "=" + cmbRol.Text;
            objMensaje.BodyEncoding = System.Text.Encoding.UTF8;
            objMensaje.IsBodyHtml = false;

            SmtpClient objCliente = new SmtpClient();
            objCliente.Credentials = new NetworkCredential("jonathan200045@gmail.com", "velandia1999");
            objCliente.Port = 587;
            objCliente.Host = "smtp.gmail.com";
            objCliente.EnableSsl = true;
            objCliente.Send(objMensaje);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            clRegistroPersonal objRegistro = new clRegistroPersonal();
            objRegistro.Documento = txtDocumento.Text;
            objRegistro.NombreP = txtNombres.Text;
            objRegistro.Direccion = txtDireccion.Text;
            objRegistro.Telefono = txtTelefono.Text;
            objRegistro.Correo = txtCorreo.Text;
            objRegistro.Contraseña = txtContraseña.Text;
            objRegistro.Rol = cmbRol.Text;

            int can = objRegistro.mtdModificarPersona();
            if (can > 0)
            {
                MessageBox.Show("Filas Afectadas" + can);
                txtDocumento.Clear();
                txtNombres.Clear();
                txtDireccion.Clear();
                txtTelefono.Clear();
                txtCorreo.Clear();
                txtContraseña.Clear();
                cmbRol.Text = null;
                txtDocumento.Focus();

            }
            else
            {
                MessageBox.Show("ERORRRRRRRRRR");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clRegistroPersonal objRegistro = new clRegistroPersonal();
            objRegistro.Documento = txtDocumento.Text;
            objRegistro.NombreP = txtNombres.Text;
            objRegistro.Direccion = txtDireccion.Text;
            objRegistro.Telefono = txtTelefono.Text;
            objRegistro.Correo = txtCorreo.Text;
            objRegistro.Contraseña = txtContraseña.Text;
            objRegistro.Rol = cmbRol.Text;

            int can = objRegistro.EliminarPersona();
            if (can > 0)
            {
                MessageBox.Show("Filas Afectadas" + can);
                frmRegistroPersonal_Load(null, null);
            }
            else
            {
                MessageBox.Show("ERORRRRRRRRRR");
            }
        }

        private void btnListarPersonal_Click(object sender, EventArgs e)
        {
            clRegistroPersonal objRegistro = new clRegistroPersonal();
            List<clRegistroPersonal> listapersonal = new List<clRegistroPersonal>();
            listapersonal = objRegistro.mtdListarPersona();
            dgvPersonal.DataSource = listapersonal;

        }

        private void dgvPersonal_DoubleClick(object sender, EventArgs e)
        {
            txtDocumento.Text = Convert.ToString(dgvPersonal.CurrentRow.Cells[0].Value);
            txtNombres.Text = Convert.ToString(dgvPersonal.CurrentRow.Cells[1].Value);
            txtDireccion.Text = Convert.ToString(dgvPersonal.CurrentRow.Cells[2].Value);
            txtTelefono.Text = Convert.ToString(dgvPersonal.CurrentRow.Cells[3].Value);
            txtCorreo.Text = Convert.ToString(dgvPersonal.CurrentRow.Cells[4].Value);
            txtContraseña.Text = Convert.ToString(dgvPersonal.CurrentRow.Cells[5].Value);
            cmbRol.Text = Convert.ToString(dgvPersonal.CurrentRow.Cells[6].Value);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            clRegistroPersonal objRegistro = new clRegistroPersonal();
            objRegistro.Documento = txtDocumento.Text;
            List<clRegistroPersonal> Buscar = new List<clRegistroPersonal>();
            dgvPersonal.DataSource = objRegistro.Repetido();

        }
    }
}
