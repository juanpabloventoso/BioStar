using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Collections;

using System.Web.UI;




namespace BioSoft
{
    public class persona
    {
         string _nombre;
         string _apellido;
         byte[] _imagen;
         int _numeroDocumento;
         int _idTiposDocumento;
         int _idPersonas;
         bool _activo;
         int _idRolesPersonas;
         byte[] _dedo1Huella;
         int _dedo1Checksum;
         byte[] _dedo2Huella;
         int _dedo2Checksum;
         int _dedos;
         DateTime _fechaAlta;
         DateTime _fechaBaja;
         DateTime _fechaNacimiento;
         string _celular;
         bool _masculino;
         bool _administrador;
         int _idNivelesSeguridad;

         public persona() { }

        public DateTime FechaNacimiento { get { return _fechaNacimiento; } set { _fechaNacimiento = value; } }
        public DateTime FechaBaja { get { return _fechaBaja; } set { _fechaBaja = value; } }
        public DateTime FechaAlta { get { return _fechaAlta; } set { _fechaAlta = value; } }
        public string Apellido { get { return _apellido; } set { _apellido = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public byte[] Imagen { get { return  _imagen; } set { _imagen = value; } }
        public int NumeroDocumento { get { return _numeroDocumento; } set { _numeroDocumento = value; } }
        public int idTiposDocumento { get { return _idTiposDocumento; } set { _idTiposDocumento = value; } }
        public string Celular { get { return _celular; } set { _celular = value; } }
        public byte[] Dedo1Huella { get { return _dedo1Huella; } set { _dedo1Huella = value; } }
        public byte[] Dedo2Huella { get { return _dedo2Huella; } set { _dedo2Huella = value; } }
        public int idPersonas { get { return _idPersonas; } set { _idPersonas = value; } }
        public int idRolesPersonas { get { return _idRolesPersonas; } set { _idRolesPersonas = value; } }
        public int Dedo1Checksum { get { return _dedo1Checksum; } set { _dedo1Checksum = value; } }
        public int Dedo2Checksum { get { return _dedo2Checksum; } set { _dedo2Checksum = value; } }
        public int Dedos { get { return _dedos; } set { _dedos = value; } }
        public bool Activo { get { return _activo; } set { _activo = value; } }
        public bool Masculino { get { return _masculino; } set { _masculino = value; } }
        public bool Administrador { get { return _administrador; } set { _administrador = value; } }
        public int idNivelesSeguridad { get { return _idNivelesSeguridad; } set { _idNivelesSeguridad = value; } }

        public string DateToSQL(DateTime Date)
        {
            return Date.Year + "/" + Date.Month + "/" + Date.Day;
        }


        public int Alta()
        {
            string huella1, huella2, fechaBaja;
            if (this.Dedo1Huella == null) huella1 = "null"; else huella1 = "'" + this.Dedo1Huella.ToString() + "'";
            if (this.Dedo2Huella == null) huella2 = "null"; else huella2 = "'" + this.Dedo2Huella.ToString() + "'";
            if (this.FechaBaja == null) fechaBaja = "null"; else fechaBaja = "'" + DateToSQL(this.FechaBaja) + "'";
            string sqlsentencia = "INSERT INTO Personas"
            + "(nombre, imagen, apellido, idRolesPersonas, idTiposDocumento, FechaNacimiento, FechaBaja, FechaAlta, Celular, Dedo1Huella, Dedo2Huella, " +
            "Dedo1Checksum, Dedo2Checksum, Dedos, Activo, Masculino, Administrador, idNivelesSeguridad, NumeroDocumento) "
            + "values ("
            + " '" + this.Nombre + "',"
            + " @Imagen,"
            + " '" + this.Apellido + "',"
            + " '" + this.idRolesPersonas + "',"
            + " '" + this.idTiposDocumento + "',"
            + " '" + this.DateToSQL(FechaNacimiento) + "',"
            + " " + fechaBaja + ","
            + " '" + this.DateToSQL(FechaAlta) + "',"
            + " '" + this.Celular + "',"
            + " " + huella1 + ","
            + " " + huella2 + ","
            + " '" + this.Dedo1Checksum + "',"
            + " '" + this.Dedo2Checksum + "',"
            + " '" + this.Dedos + "',"
            + " '" + this.Activo + "',"
            + " '" + this.Masculino + "',"
            + " '" + this.Administrador + "',"
            + " '" + this.idNivelesSeguridad + "',"
            + " '" + this.NumeroDocumento + " ')";
            Persistence.Database oDatos = new Persistence.Database();
            oDatos.conectar();
            int ID = oDatos.Ejecutar_Sentencia_Imagen(sqlsentencia, this.Imagen);
            oDatos.Desconectar();
            return ID;
        }


        public void Modificacion()
        {
            string huella1, huella2, fechaBaja;
            if (this.Dedo1Huella == null) huella1 = "null"; else huella1 = "'" + this.Dedo1Huella.ToString() + "'";
            if (this.Dedo2Huella == null) huella2 = "null"; else huella2 = "'" + this.Dedo2Huella.ToString() + "'";
            if (this.FechaBaja == null) fechaBaja = "null"; else fechaBaja = "'" + DateToSQL(this.FechaBaja) + "'";
            string sqlsentencia = "UPDATE Personas SET "
            + "nombre = " + this.Nombre +","
            + "imagen = @Imagen,"
            + "apellido = " + this.Apellido +","
            + "idRolesPersonas = " + this.idRolesPersonas +","
            + "idTiposDocumento = " + this.idTiposDocumento +","
            + "FechaNacimiento = " + this.FechaNacimiento +","
            + "FechaBaja = " + this.FechaBaja +","
            + "FechaAlta = " + this.FechaAlta +","
            + "Celular = " + this.Celular +","
            + "Dedo1Huella = " + this.Dedo1Huella +","
            + "Dedo2Huella = " + this.Dedo2Huella +","
            + "Dedo1Checksum = " + this.Dedo1Checksum +","
            + "Dedo2Checksum = " + this.Dedo2Checksum +","
            + "Dedos = " + this.Dedos +","
            + "Activo = " + this.Activo +","
            + "Masculino = " + this.Masculino +","
            + "Administrador = " + this.Administrador +","
            + "idNivelesSeguridad = " + this.idNivelesSeguridad +","
            + "NumeroDocumento = " + this.NumeroDocumento
            + " WHERE idPersonas = " + this.idPersonas;
            Persistence.Database oDatos = new Persistence.Database();
            oDatos.conectar();
            oDatos.Desconectar();
            oDatos.Ejecutar_Sentencia_Imagen(sqlsentencia, this.Imagen);
        }

    }
}
