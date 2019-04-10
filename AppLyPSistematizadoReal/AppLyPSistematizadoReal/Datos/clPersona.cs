using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLyPSistematizadoReal.Datos
{
    class clPersona
    {
        public DataTable mtdListar()
        {
            clConexion conexion = new clConexion();
            DataTable dtempleado = new DataTable();
            string consulta = "Select *from Persona";
            dtempleado = conexion.mtdDesconectado(consulta);
            return dtempleado;
        }
    }
}
