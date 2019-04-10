using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppLyPSistematizadoReal.Datos
{
    class clAutomovil3
    {
        public string Placa { get; set; }
        public string TipoV { get; set; }
        //public string FechaS { get; set; }
        public string FechaHoraE { get; set; }
        public string FechaHoraS { get; set; }
        //public string TipoSe { get; set; }
        public string Valor { get; set; }
        //public string TotalP { get; set; }
        //public int IdAutomovil { get; set; }
        //public int IdTarifa { get; set; }
        //public string Tarifa { get; set; }
        public string TipoS { get; set; }



        clConexion objconexion = new clConexion();


        public List<clAutomovil3> mtdListar()
        {
            List<clAutomovil3> listaAutomovil = new List<clAutomovil3>();
            DataTable dtparqueo = new DataTable();

            //string consulta = "select Placa,TipoV from Automovil ";

            string consulta = "select Placa,TipoV,FechaHoraE,FechaHoraS,TipoS,Valor FROM Automovil inner join Servicio on  (Servicio.IdAutomovil=Automovil.IdAutomovil) inner join Tarifa on (Tarifa.IdTarifa=Servicio.IdTarifa) where TipoS='PARQUEO1' or TipoS='PARQUEO2' or TipoS='PARQUEO3' ";
            //string consulta = "select Placa,TipoV,FechaHoraE,FechaHoraS,TipoS,Valor FROM Automovil inner join Servicio on  (Servicio.IdAutomovil=Automovil.IdAutomovil) inner join Tarifa on (Tarifa.IdTarifa=Servicio.IdServicio) where	TipoS='PARQUEO1'  or	TipoS='PARQUEO2' or 	TipoS='PARQUEO3'";
            dtparqueo = objconexion.mtdDesconectado(consulta);


            for (int i = 0; i < dtparqueo.Rows.Count; i++)
            {
                clAutomovil3 objAutomovil = new clAutomovil3();


                objAutomovil.Placa = dtparqueo.Rows[i]["Placa"].ToString();
                objAutomovil.TipoV = dtparqueo.Rows[i]["TipoV"].ToString();
                objAutomovil.FechaHoraE = dtparqueo.Rows[i]["FechaHoraE"].ToString();
                objAutomovil.FechaHoraS = dtparqueo.Rows[i]["FechaHoraS"].ToString();
                objAutomovil.TipoS = dtparqueo.Rows[i]["TipoS"].ToString();
                objAutomovil.Valor = dtparqueo.Rows[i]["Valor"].ToString();

                listaAutomovil.Add(objAutomovil);

            }
            return listaAutomovil;
        }
        public int mtdlistarregis()
        {

            String consulta = "insert into Automovil (Placa,TipoV)" +
                              " values('" + Placa + "','" + TipoV + "')";

            int usure = objconexion.mtdConectado(consulta);
            return usure;
        }
        public int mtdlistarservicio()
        {

            String consulta = "insert into Servicio (TipoS,FechaHoraE,FechaHoraS,TotalP,IdAutomovil,IdTarifa)" +
                              " values('" + TipoS + "','" + FechaHoraE + "','" + FechaHoraS + "')";

            int usure1 = objconexion.mtdConectado(consulta);
            return usure1;
        }

        public int mtdasignarvehi()
        {

            DataTable dtServicio = new DataTable();
            String consulta5 = "select max (IdAutomovil) from Automovil AS Ultimo  ";
            dtServicio = objconexion.mtdDesconectado(consulta5);
            int encontro = int.Parse(dtServicio.Rows[0][0].ToString());
            return encontro;
        }


        public DataTable mtdbuscar()
        {
            DataTable dtbuscar = new DataTable();
            //string consulta = "select Placa,TipoV,FechaHoraE,FechaHoraS,Tipo,Valor FROM Automovil inner join Servicio on  (Servicio.IdAutomovil=Automovil.IdAutomovil) inner join Tarifa on (Tarifa.IdTipo=Servicio.IdServicio)where	Tipo='PARQUEO1'  or	Tipo='PARQUEO2' ";
            string consulta = "select Placa,TipoV FROM Automovil where Placa ='" + Placa + "'";

            //string consulta = "select Placa,TipoV,FechaHoraE,FechaHoraS,TipoS,Valor FROM Automovil inner join Servicio on  (Servicio.IdAutomovil=Automovil.IdAutomovil) inner join Tarifa on (Tarifa.IdTarifa=Servicio.IdTarifa)where Placa ='" + Placa + "'";
            dtbuscar = objconexion.mtdDesconectado(consulta);
            return dtbuscar;
        }
        public int mtdeditar()
        {
            string consulta = "update Automovil set Placa='" + Placa + "',TipoV='" + TipoV + "' WHERE Placa= '" + Placa + "'";
            int canedi = objconexion.mtdConectado(consulta);
            return canedi;
        }
        public int mtdeliminar()
        {
            string consulta = "delete Automovil where Placa='" + Placa + "'";
            int cont = objconexion.mtdConectado(consulta);
            return cont;
        }
        //public int mtdasignartarifa()
        //{

        //    //DataTable dttarifa = new DataTable();
        //    //string consulta= "select IdTarifa from Tarifa where  TipoSe='"+Tarifa+"'";
        //    //dttarifa = objconexion.mtdDesconectado(consulta);
        //    //int encontro = int.Parse(dttarifa.Rows[0][0].ToString());
        //    //return encontro;

        //}

    }
}
