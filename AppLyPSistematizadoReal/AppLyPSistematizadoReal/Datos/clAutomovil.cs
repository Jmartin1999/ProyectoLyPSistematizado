using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLyPSistematizadoReal.Datos
{
    class clAutomovil
    {
        public int IdAutomovil { get; set; }
        public string Placa { get; set; }
        public string TipoV { get; set; }
        public string Observaciones { get; set; }
        public int IdCliente { get; set; }
        clConexion objConexion = new clConexion();
        List<clAutomovil> listaAutomovil = new List<clAutomovil>();
        public List<clAutomovil> mtdAutoCompletarAutomovil()
        {
            DataTable dtAutomovil = new DataTable();
            string consulta = "select * from Automovil where Placa='" + Placa + "'";
            dtAutomovil = objConexion.mtdDesconectado(consulta);
            for (int i = 0; i < dtAutomovil.Rows.Count; i++)
            {
                clAutomovil objAutomovil = new clAutomovil();
                objAutomovil.IdAutomovil = Convert.ToInt32(dtAutomovil.Rows[i]["IdAutomovil"]);
                objAutomovil.Placa = dtAutomovil.Rows[i]["Placa"].ToString();
                objAutomovil.TipoV = dtAutomovil.Rows[i]["TipoV"].ToString();
                objAutomovil.Observaciones = dtAutomovil.Rows[i]["Observaciones"].ToString();
                objAutomovil.IdCliente = Convert.ToInt32(dtAutomovil.Rows[i]["IdCliente"]);
                listaAutomovil.Add(objAutomovil);

            }
            return listaAutomovil;
        }
        public DataTable mtdMostrar()
        {
            DataTable dtAutomovil = new DataTable();
            string consulta = "select Documento,Nombres,Telefono,Placa,TipoV,Observaciones from Cliente inner join Automovil on(Automovil.IdCliente=Cliente.IdCliente)";
            dtAutomovil = objConexion.mtdDesconectado(consulta);
            return dtAutomovil;
        }
        public int mtdRegistrarAutomovil(int IdCliente)
        {
            string consulta = "insert into Automovil(Placa,TipoV,Observaciones,IdCliente) values ('" + Placa + "','" + TipoV + "','" + Observaciones + "','" + IdCliente + "')";
            int cantidad = objConexion.mtdConectado(consulta);
            return cantidad;
        }
        public int mtdModificarAutomovil()
        {
            string consulta = "Update  Automovil set Placa= '" + Placa + "',TipoV='" + TipoV + "',Observaciones='" + Observaciones + "'where Placa='" + Placa + "'";
            int cantidad = objConexion.mtdConectado(consulta);
            return cantidad;
        }
        public int mtdEliminarAutomovil()
        {
            string consulta = "Delete from Automovil where Placa='" + Placa + "'";
            int cantidad = objConexion.mtdConectado(consulta);
            return cantidad;
        }
        public DataTable mtdMostrarTodo()
        {
            DataTable dtMostrar = new DataTable();
            string consulta = "select  Cliente.Documento,Cliente.Nombres,Cliente.Telefono,Placa,Observaciones from Automovil inner join Cliente on (Automovil.IdAutomovil=Automovil.IdCliente) where Placa='" + Placa + "'";
            dtMostrar = objConexion.mtdDesconectado(consulta);
            return dtMostrar;
        }

    }
}
