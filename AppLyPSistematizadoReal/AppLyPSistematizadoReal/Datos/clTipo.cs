using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AppLyPSistematizadoReal.Datos
{
    class clTipo
    {
        public string TipoServicio { get; set; }
        public string TipoVehiculo { get; set; }
        public string Costo { get; set; }

        clConexion objConexion = new clConexion();


        public List<clTipo> mtdListar()
        {
            List<clTipo> ListaTipo = new List<clTipo>();
            DataTable dtTipo = new DataTable();
            string Consulta = "select * from Tarifa";
            dtTipo = objConexion.mtdDesconectado(Consulta);
            for (int i = 0; i < dtTipo.Rows.Count; i++)
            {
                clTipo objTipo = new clTipo();
                objTipo.TipoServicio = dtTipo.Rows[i]["TipoS"].ToString();
                objTipo.TipoVehiculo = dtTipo.Rows[i]["TipoVe"].ToString();
                objTipo.Costo = dtTipo.Rows[i]["Valor"].ToString();
                ListaTipo.Add(objTipo);

            }
            return ListaTipo;
        }
        public int mtdRegistro()

        {
            string Consulta = "Insert into Tarifa(TipoS,TipoVe,Valor) values ('" + TipoServicio + "','" + TipoVehiculo + "','" + Costo + "')";
            int dtRegistro = objConexion.mtdConectado(Consulta);
            return dtRegistro;
        }
        public DataTable mtdBuscar()
        {
            DataTable dtBuscar = new DataTable();
            string Consulta = "select * from Tarifa where TipoS='" + TipoServicio + "'  ";
            dtBuscar = objConexion.mtdDesconectado(Consulta);
            return dtBuscar;
        }
        public int mtdModificar()
        {
            string Consulta = "update Tarifa set TipoS='" + TipoServicio + "' , TipoVe='" + TipoVehiculo + "',Valor='" + Costo + "'where TipoS='" + TipoServicio + "'  ";
            int Cant = objConexion.mtdConectado(Consulta);
            return Cant;

        }
        public int mtdEliminar()
        {
            string Consulta = "Delete Tarifa where TipoS='" + TipoServicio + "'";
            int Canti = objConexion.mtdConectado(Consulta);
            return Canti;



        }
    }
}
