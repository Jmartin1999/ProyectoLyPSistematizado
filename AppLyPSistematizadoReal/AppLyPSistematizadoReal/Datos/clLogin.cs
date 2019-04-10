using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLyPSistematizadoReal.Datos
{
    class clLogin
    {
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }


        clConexion objConexion = new clConexion();
        List<clLogin> listaUsuarios = new List<clLogin>();
        List<clLogin> ListarCorreos = new List<clLogin>();
        List<clLogin> listaOlvidar = new List<clLogin>();

        public int mtdModificarContraseña()
        {
            string consulta = "Update Persona set Contraseña='" + Contraseña + "' where  Contraseña='" + Contraseña + "'";
            int cantidad = objConexion.mtdConectado(consulta);
            return cantidad;
        }
        public List<clLogin> mtdListarSesion()
        {

            DataTable dtLogin = new DataTable();
            string consulta = "select Correo,Contraseña,Rol from Persona ";
            dtLogin = objConexion.mtdDesconectado(consulta);
            for (int i = 0; i < dtLogin.Rows.Count; i++)
            {
                clLogin objLogin = new clLogin();
                objLogin.Correo = dtLogin.Rows[i]["Correo"].ToString();
                objLogin.Contraseña = dtLogin.Rows[i]["Contraseña"].ToString();
                objLogin.Rol = dtLogin.Rows[i]["Rol"].ToString();
                listaUsuarios.Add(objLogin);
            }
            return listaUsuarios;

        }
        public List<clLogin> mtdOlvidar(string email)
        {

            DataTable dtOlvidar = new DataTable();
            string consulta = "select  Correo,Contraseña from Persona where Correo='" + email + "'";
            dtOlvidar = objConexion.mtdDesconectado(consulta);
            for (int i = 0; i < dtOlvidar.Rows.Count; i++)
            {
                clLogin objLogin = new clLogin();

                objLogin.Contraseña = dtOlvidar.Rows[i]["Correo"].ToString();
                objLogin.Contraseña = dtOlvidar.Rows[i]["Contraseña"].ToString();

                listaOlvidar.Add(objLogin);
            }
            return listaOlvidar;

        }
        public List<clLogin> mtdListarCorreos()
        {
            DataTable dtLogin1 = new DataTable();
            string consulta = "select Correo  from Persona";
            dtLogin1 = objConexion.mtdDesconectado(consulta);
            for (int i = 0; i < dtLogin1.Rows.Count; i++)
            {
                clLogin objLogin = new clLogin();
                objLogin.Correo = dtLogin1.Rows[i]["Correo"].ToString();
                ListarCorreos.Add(objLogin);
            }


            return ListarCorreos;

        }
    }
}
