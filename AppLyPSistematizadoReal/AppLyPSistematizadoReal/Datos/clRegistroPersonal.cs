using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLyPSistematizadoReal.Datos
{
    class clRegistroPersonal
    {
        public string Documento { get; set; }
        public string NombreP { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }

        clConexion objConexion = new clConexion();
        List<clRegistroPersonal> listaPersona = new List<clRegistroPersonal>();
        List<clRegistroPersonal> listaDocumento = new List<clRegistroPersonal>();
        public int mtdRegistrar()
        {
            string consulta = "insert into Persona(Documento,NombreP,Direccion,Telefono,Correo,Contraseña,Rol) values ('" + Documento + "','" + NombreP + "','" + Direccion + "','" + Telefono + "','" + Correo + "','" + Contraseña + "','" + Rol + "')";
            int cantidad = objConexion.mtdConectado(consulta);
            return cantidad;
        }
        public int mtdModificarPersona()
        {
            string consulta = "Update Persona set Documento='" + Documento + "',NombreP='" + NombreP + "',Direccion='" + Direccion + "',Telefono='" + Telefono + "',Correo='" + Correo + "',Rol='" + Rol + "' where  Documento='" + Documento + "'";
            int cantidad = objConexion.mtdConectado(consulta);
            return cantidad;
        }
        public int EliminarPersona()
        {
            string consulta = "Delete from  Persona  where Documento '" + Documento + "'";
            int cantidad = objConexion.mtdConectado(consulta);
            return cantidad;
        }
        public List<clRegistroPersonal> mtdListarPersona()
        {

            DataTable dtPersona = new DataTable();
            string consulta = "select * from Persona";
            dtPersona = objConexion.mtdDesconectado(consulta);
            for (int i = 0; i < dtPersona.Rows.Count; i++)
            {
                clRegistroPersonal objRegistro = new clRegistroPersonal();
                objRegistro.Documento = dtPersona.Rows[i]["Documento"].ToString();
                objRegistro.NombreP = dtPersona.Rows[i]["NombreP"].ToString();
                objRegistro.Direccion = dtPersona.Rows[i]["Direccion"].ToString();
                objRegistro.Telefono = dtPersona.Rows[i]["Telefono"].ToString();
                objRegistro.Correo = dtPersona.Rows[i]["Correo"].ToString();
                objRegistro.Contraseña = dtPersona.Rows[i]["Contraseña"].ToString();
                objRegistro.Rol = dtPersona.Rows[i]["Rol"].ToString();

                listaPersona.Add(objRegistro);
            }
            return listaPersona;

        }
        public List<clRegistroPersonal> Repetido()
        {
            DataTable Repetir = new DataTable();
            string consulta = "select * from Persona where Documento = '" + Documento + "'";
            Repetir = objConexion.mtdDesconectado(consulta);
            for (int i = 0; i < Repetir.Rows.Count; i++)
            {
                clRegistroPersonal objRegistro = new clRegistroPersonal();
                objRegistro.Documento = Repetir.Rows[i]["Documento"].ToString();
                objRegistro.NombreP = Repetir.Rows[i]["NombreP"].ToString();
                objRegistro.Direccion = Repetir.Rows[i]["Direccion"].ToString();
                objRegistro.Telefono = Repetir.Rows[i]["Telefono"].ToString();
                objRegistro.Correo = Repetir.Rows[i]["Correo"].ToString();
                objRegistro.Contraseña = Repetir.Rows[i]["Contraseña"].ToString();
                objRegistro.Rol = Repetir.Rows[i]["Rol"].ToString();


                listaDocumento.Add(objRegistro);
            }
            return listaDocumento;
        }
    }
}
