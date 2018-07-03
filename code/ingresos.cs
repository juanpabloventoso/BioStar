using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Collections;
using System.Web.UI;
using BioSoft;


namespace BioSoft
{
    class ingresos
    {


int _idIngresos;
int _idPersonas;
int _idUbicacionesIngreso;
int _idUbicacionesEgreso;
int _tiempoPersonal;
int _tiempoExtendido;
string _codigoTarjeta;
string _pertenencias;
string _vehiculo;
string _lote;
bool _activo;
DateTime _fechaIngreso;
DateTime _fechaEgreso;	

   

     public ingresos()

        { }

     public bool Activo
     {
         get { return _activo; }
         set { _activo = value; }
     }         
     public string Vehiculo
     {
         get { return _vehiculo; }
         set { _vehiculo = value; }
     }
     public string Lote
     {
         get { return _lote; }
         set { _lote = value; }
     }
     public string Pertenencias
     {
         get { return _pertenencias; }
         set { _pertenencias = value; }
     }
     public string CodigoTarjeta
     {
         get { return _codigoTarjeta; }
         set { _codigoTarjeta = value; }
     }       
     public int TiempoExtendido
     {
         get { return _tiempoExtendido; }
         set { _tiempoExtendido = value; }
     }       
     public int TiempoPersonal
     {
         get { return _tiempoPersonal; }
         set { _tiempoPersonal = value; }
     }
     public int idUbicacionesEgreso
     {
         get { return _idUbicacionesEgreso; }
         set { _idUbicacionesEgreso = value; }
     }
     public int idUbicacionesIngreso
     {
         get { return _idUbicacionesIngreso; }
         set { _idUbicacionesIngreso = value; }
     }
     public DateTime FechaIngreso
        {
            get { return _fechaIngreso; }
            set { _fechaIngreso = value; }
        }
     public DateTime FechaEgreso
        {
            get { return _fechaEgreso; }
            set { _fechaEgreso = value; }
        }
     public int idIngresos
    {
        get { return _idIngresos; }
        set { _idIngresos = value; }
    }
     public int idPersonas
    {
        get { return _idPersonas; }
        set { _idPersonas = value; }
    }


     public int Alta()
     {
         string fechaIngreso, fechaEgreso;
         if (this.FechaIngreso == null) fechaIngreso = "null"; else fechaIngreso = this.FechaIngreso.ToString();
         if (this.FechaEgreso == null) fechaEgreso = "null"; else fechaEgreso = this.FechaEgreso.ToString();
         string sqlsentencia = "INSERT INTO Ingresos"
         + "(activo, vehiculo, pertenencias, codigoTarjeta, tiempoExtendido, tiempoPersonal, idUbicacionesEgreso, idUbicacionesIngreso, fechaIngreso, fechaEgreso, Lote, idPersonas)"
         + "values ("
         + " '" + this.Activo + "',"
         + " '" + this.Vehiculo + "',"
         + " '" + this.Pertenencias + "',"
         + " '" + this.CodigoTarjeta + "',"
         + " '" + this.TiempoExtendido + "',"
         + " '" + this.TiempoPersonal + "',"
         + " '" + this.idUbicacionesEgreso + "',"
         + " '" + this.idUbicacionesIngreso + "',"
         + " " + Funciones.FechaASQL(this.FechaIngreso) + ","
         + " " + Funciones.FechaASQL(this.FechaEgreso) + ","
         + " '" + this.Lote + "',"
         + " '" + this.idPersonas + "')";
         Persistence.Database oDatos = new Persistence.Database();
         oDatos.conectar();
         int ID = oDatos.Ejecutar_Sentencia(sqlsentencia);
         oDatos.Desconectar();
         return ID;
     }


     public void Modificacion()
     {
         string sqlsentencia = "UPDATE Ingresos SET "
         + "Activo = '" + this.Activo + "',"
         + "Vehiculo = '" + this.Vehiculo + "',"
         + "Pertenencias = '" + this.Pertenencias + "',"
         + "CodigoTarjeta = '" + this.CodigoTarjeta + "',"
         + "TiempoExtendido = '" + this.TiempoExtendido + "',"
         + "TiempoPersonal = '" + this.TiempoPersonal + "',"
         + "idUbicacionesEgreso = '" + this.idUbicacionesEgreso + "',"
         + "idUbicacionesIngreso =  '" + this.idUbicacionesIngreso + "',"
         + "fechaIngreso =  " + Funciones.FechaASQL(this.FechaIngreso) + ","
         + "fechaEgreso =  " + Funciones.FechaASQL(this.FechaEgreso) + ","
         + "Lote = '" + this.Lote + "',"
         + "idPersonas = '" + this.idPersonas + "'"
         + " WHERE idIngresos = " + this.idIngresos;
         Persistence.Database oDatos = new Persistence.Database();
         oDatos.conectar();
         oDatos.Ejecutar_Sentencia(sqlsentencia);
         oDatos.Desconectar();
     }


     public void getIngreso(int ID)
     {
         string sqlSelect = "SELECT * FROM Ingresos "
         + " WHERE idIngresos ='" + ID + "'";
         Persistence.Database oDatos;
         oDatos = new Persistence.Database();
         oDatos.conectar();
         oDatos.Ejecutar_Consulta(sqlSelect);
         oDatos.Desconectar();
         this.idIngresos = int.Parse(oDatos.Tabla.Rows[0].ItemArray[0].ToString());
         this.idPersonas = int.Parse(oDatos.Tabla.Rows[0].ItemArray[1].ToString());
         this.CodigoTarjeta = (oDatos.Tabla.Rows[0].ItemArray[2].ToString());
         if (oDatos.Tabla.Rows[0].ItemArray[3].ToString() != "")
             this.TiempoPersonal = int.Parse(oDatos.Tabla.Rows[0].ItemArray[3].ToString());
         if (oDatos.Tabla.Rows[0].ItemArray[4].ToString() != "")
             this.TiempoExtendido = int.Parse(oDatos.Tabla.Rows[0].ItemArray[4].ToString());
         this.Activo = bool.Parse(oDatos.Tabla.Rows[0].ItemArray[5].ToString());
         if (oDatos.Tabla.Rows[0].ItemArray[6].ToString() != "")
         this.FechaIngreso = DateTime.Parse(oDatos.Tabla.Rows[0].ItemArray[6].ToString());
         this.idUbicacionesIngreso = int.Parse(oDatos.Tabla.Rows[0].ItemArray[7].ToString());
         if (oDatos.Tabla.Rows[0].ItemArray[8].ToString() != "")
             this.idUbicacionesEgreso = int.Parse(oDatos.Tabla.Rows[0].ItemArray[8].ToString());
         this.Pertenencias = (oDatos.Tabla.Rows[0].ItemArray[9].ToString());
         this.Vehiculo = (oDatos.Tabla.Rows[0].ItemArray[10].ToString());
         this.Lote = (oDatos.Tabla.Rows[0].ItemArray[12].ToString());
         if (oDatos.Tabla.Rows[0].ItemArray[13].ToString() != "")
             this.FechaEgreso = DateTime.Parse(oDatos.Tabla.Rows[0].ItemArray[13].ToString());

     }



    }
	


}
