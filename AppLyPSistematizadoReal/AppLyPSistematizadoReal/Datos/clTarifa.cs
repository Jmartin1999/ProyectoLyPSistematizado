using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLyPSistematizadoReal.Datos
{
    class clTarifa
    {
        public int IdTarifa { get; set; }
        public string TipoS { get; set; }
        public string TipoVe { get; set; }
        public string Valor { get; set; }
        List<clTarifa> ListaTarifa = new List<clTarifa>();
        List<clTarifa> Lista = new List<clTarifa>();
        clConexion objconexion = new clConexion();
        public List<clTarifa> mtdListar()
        {

            DataTable dtTarifa = new DataTable();
            string consulta = "select * from Tarifa ";
            dtTarifa = objconexion.mtdDesconectado(consulta);
            for (int i = 0; i < dtTarifa.Rows.Count; i++)
            {
                clTarifa objTarifa = new clTarifa();
                objTarifa.IdTarifa = Convert.ToInt32(dtTarifa.Rows[i]["IdTarifa"]);
                objTarifa.TipoS = dtTarifa.Rows[i]["TipoS"].ToString();
                objTarifa.TipoVe = dtTarifa.Rows[i]["TipoVe"].ToString();
                objTarifa.Valor = dtTarifa.Rows[i]["Valor"].ToString();
                ListaTarifa.Add(objTarifa);
            }

            return ListaTarifa;
        }
        public DataTable mtdMensualidades()
        {
            DataTable dtTarifa = new DataTable();
            string consulta = "select * from Tarifa where TipoS='Mensualidad1' or TipoS='Mensualidad2' or TipoS='Mensualidad3'";
            dtTarifa = objconexion.mtdDesconectado(consulta);


            return dtTarifa;
        }
    }
}
