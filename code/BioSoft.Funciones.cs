using System;
using System.Collections.Generic;
using System.Text;

namespace BioSoft
{
    public static class Funciones
    {

        public static string FechaASQL(DateTime AFecha)
        {
            if ((AFecha == null) || (AFecha.Year == 1)) return "NULL";
            return "'" + AFecha.ToString("MM/dd/yyyy HH:mm:ss") + "'";
//            return AFecha.Year + "/" + AFecha.Month + "/" + AFecha.Day + " " +
//                AFecha.Hour + ":" + AFecha.Minute + ":" + AFecha.Second;
        }
    }
}
