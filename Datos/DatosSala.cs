﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Datos
{
    public class DatosSala
    {
        public static DataTable ConsultarTabla()
        {
            Conexion con = new Conexion();
            string query = "SELECT idSalas, concat(descripcion,'- Cap.: ',capacidad) descripcion FROM cinearg.salas s inner join cinearg.tipos_salas ts on s.FK_Tipo_Salas = ts.idTipos_Salas; ";
            return con.SelectDataTable(query);
        }
    }
}
