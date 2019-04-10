using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AppLyPSistematizadoReal.Datos
{
    class VclLavadero
    {
        public string PLACA { get; set; }
        public string TIPOVEHICULO { get; set; }
        public string SERVICIO { get; set; }
        public string VALOR { get; set; }
        public string IdAutomovil { get; set; }
        public int IdPersona { get; set; }
        public string IdTarifa { get; set; }
        public string IDSERVICIO { get; set; }
        clConexion objConeexion = new clConexion();

        public List<VclLavadero> mtdListar()
        {
            List<VclLavadero> listalavado = new List<VclLavadero>();
            DataTable dtLavado = new DataTable();
            string consulta = "select Placa,TipoV,TipoS,Valor from Automovil inner join Servicio on (Servicio.IdAutomovil=Automovil.IdAutomovil) inner join Tarifa on  (Servicio.IdTarifa = Tarifa.IdTipo) WHERE TipoS= 'LAVADO1' OR TipoS= 'LAVADO2' OR TipoS='LAVADO3' ";
            dtLavado = objConeexion.mtdDesconectado(consulta);

            for (int i = 0; i < dtLavado.Rows.Count; i++)
            {
                VclLavadero objLavado = new VclLavadero();
                objLavado.PLACA = dtLavado.Rows[i]["Placa"].ToString();
                objLavado.TIPOVEHICULO = dtLavado.Rows[i]["TipoV"].ToString();
                objLavado.SERVICIO = dtLavado.Rows[i]["TipoS"].ToString();
                ; objLavado.VALOR = dtLavado.Rows[i]["Valor"].ToString();
                listalavado.Add(objLavado);
            }
            return listalavado;

        }
        public int mtdregistrar()
        {
            string consulta = "insert into Automovil (Placa,TipoV)"
                + "values ('" + PLACA + "','" + TIPOVEHICULO + "')";
            int cint = objConeexion.mtdConectado(consulta);
            return cint;
        }
        public int mtdasignarvehi()
        {
            DataTable dtServicio = new DataTable();
            String consulta = "select max (IdAutomovil) from Automovil AS Ultimo  ";
            dtServicio = objConeexion.mtdDesconectado(consulta);
            int encontro = int.Parse(dtServicio.Rows[0][0].ToString());
            return encontro;
        }
        public int mtdservicio()
        {
            String consulta = "insert into Servicio ( TotalP, IdAutomovil, IdPersona,IdTarifa)" + " values(" + VALOR + "','" + IdAutomovil + "','" + IdPersona + "','" + IdTarifa + "')";
            int usure2 = objConeexion.mtdConectado(consulta);
            return usure2;
        }
        public DataTable mtdTarifa()
        {
            DataTable dttarifa = new DataTable();
            String consulta = "Select IdTipo from Tarifa WHERE TipoS= 'LAVADO1' OR TipoS= 'LAVADO2' OR TipoS='LAVADO3' ";
            dttarifa = objConeexion.mtdDesconectado(consulta);
            return dttarifa;
        }
    }
}
