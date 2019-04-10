using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLyPSistematizadoReal.Datos
{
    class clPago
    {
        public int IdAutomovil { get; set; }
        public string FechaPago { get; set; }
        public string Valor { get; set; }
        public int IdTarifa { get; set; }
        clConexion objConexion = new clConexion();
        public int mtdRegistrarPago(int IdAutomovil, int IdTarifa)
        {
            string consulta = "insert into Pago(FechaPago,ValorPago,IdAutomovil,IdTarifa) values ('" + FechaPago + "','" + Valor + "','" + IdAutomovil + "','" + IdTarifa + "')";
            int cantidad = objConexion.mtdConectado(consulta);
            return cantidad;
        }
        public DataTable mtdMostrar()
        {
            DataTable dtPago = new DataTable();
            string consulta = "select Automovil.Placa,Automovil.TipoV,FechaPago,ValorPago,Tarifa.TipoS from  Automovil inner join Pago on(Automovil.IdAutomovil=Pago.IdAutomovil) inner join Tarifa on (Pago.IdTarifa=Tarifa.IdTarifa)";
            dtPago = objConexion.mtdDesconectado(consulta);
            return dtPago;
        }
    }
}
