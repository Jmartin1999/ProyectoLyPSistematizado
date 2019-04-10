using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLyPSistematizadoReal.Datos
{
    class clCliente
    {
        public int IdCliente { get; set; }
        public string Documento { get; set; }
        public string Nombres { get; set; }
        public string Telefono { get; set; }
        clConexion objConexion = new clConexion();
        List<clCliente> ListaCliente = new List<clCliente>();
        public List<clCliente> mtdAutoCompletar()
        {
            DataTable dtCliente = new DataTable();
            string consulta = "select * from Cliente where Documento='" + Documento + "'";
            dtCliente = objConexion.mtdDesconectado(consulta);
            for (int i = 0; i < dtCliente.Rows.Count; i++)
            {
                clCliente objCliente = new clCliente();
                objCliente.IdCliente = Convert.ToInt32(dtCliente.Rows[i]["IdCliente"].ToString());
                objCliente.Documento = dtCliente.Rows[i]["Documento"].ToString();
                objCliente.Nombres = dtCliente.Rows[i]["Nombres"].ToString();
                objCliente.Telefono = dtCliente.Rows[i]["Telefono"].ToString();
                ListaCliente.Add(objCliente);

            }
            return ListaCliente;

        }
        public int mtdRegistrarCliente()
        {
            string consulta = "insert into Cliente(Documento,Nombres,Telefono) values ('" + Documento + "','" + Nombres + "','" + Telefono + "')";
            int cantidad = objConexion.mtdConectado(consulta);
            return cantidad;
        }
        public int mtdModificarCliente()
        {
            string consulta = "Update  Cliente set Documento='" + Documento + "',Nombres='" + Nombres + "',Telefono='" + Telefono + "' where Documento='" + Documento + "'";
            int cantidad = objConexion.mtdConectado(consulta);
            return cantidad;
        }
        public int mtdEliminarCliente()
        {
            string consulta = "Delete from Cliente where Documento='" + Documento + "'";
            int cantidad = objConexion.mtdConectado(consulta);
            return cantidad;
        }
        //public int mtdAsignarVehiculo()
        //{
        //    //DataTable dtCliente = new DataTable();
        //    //string consulta = "select max (IdCliente) from Cliente as Ultimo;";
        //    //dtCliente = objConexion.mtdDesconectado(consulta);
        //    //int encontro= int.Parse(dtCliente.Rows[0][0].ToString());
        //    //return encontro;
        //}

    }
}
