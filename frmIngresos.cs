using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BioSoft;
using System.IO;

namespace BioStarCSharp
{
    public partial class frmIngresos : Form
    {
        ingresos _ingresos = new ingresos();
        DispositivoBioStar _Dispositivo;


        public frmIngresos()
        {
            InitializeComponent();
        }

        private void brnAceptarIngreso_Click(object sender, EventArgs e)
        {
            
            _ingresos.Activo = true;
//            _ingresos.CodigoTarjeta = edtCodigoTarjeta.Text;
            _ingresos.FechaIngreso = DateTime.Now;
            _ingresos.Pertenencias = edtPertenecias.Text;
            if (edtTiempoPersonal.Text != "")
                _ingresos.TiempoPersonal = int.Parse(edtTiempoPersonal.Text);
            _ingresos.Lote = edtLote.Text;
            _ingresos.Vehiculo = edtVehiculo.Text;
            _ingresos.idUbicacionesIngreso = 1;
            _ingresos.idUbicacionesEgreso = 1;
            _ingresos.Modificacion();
            this.Close();

        }

        public void setDispositivo(DispositivoBioStar Dispositivo)
        {
            this._Dispositivo = Dispositivo;
        }

        //private void btnLeerDispositivo_Click(object sender, EventArgs e)
        //{
        //    _Dispositivo.LeerLogIngresosExitosos();
        //   int ID = ((LogBioStar)_Dispositivo.Log[_Dispositivo.Log.Count - 1]).UsuarioID;

        //    persona _persona = new persona();
        //    _persona.getPersona(ID);
        //    string apellido = _persona.Apellido;
        //    edtNombreApellido.Text = _persona.Apellido + " " + _persona.Nombre;

        //    Persistence.Database oDatos;
        //    oDatos = new Persistence.Database();
        //    oDatos.conectar();
        //    oDatos.Ejecutar_Consulta("SELECT TipoDocumento FROM TiposDocumento WHERE idTiposDocumento = " + _persona.idTiposDocumento);
        //    edtTipoNumero.Text = oDatos.Tabla.Rows[0].ItemArray[0].ToString() + " N° " + _persona.NumeroDocumento.ToString();
        //    oDatos.Desconectar();
        //    oDatos = new Persistence.Database();
        //    oDatos.conectar();
        //    oDatos.Ejecutar_Consulta("SELECT RolPersona FROM RolesPersonas WHERE idRolesPersonas = " + _persona.idRolesPersonas);
        //    edtRol.Text = oDatos.Tabla.Rows[0].ItemArray[0].ToString();
        //    oDatos.Desconectar();
        //    _ingresos.idPersonas = ID;
        //    MemoryStream mem = _persona.ImagenPersonaPorId(_ingresos.idPersonas);
        //    PbxImagen.Image = Image.FromStream(mem);
        //}



        public void modificarIngreso(int idPersonas, int idIngresos)
       
        {
            persona _persona = new persona();
            _persona.getPersona(idPersonas);
            string apellido = _persona.Apellido;
            edtNombreApellido.Text = _persona.Apellido + " " + _persona.Nombre;

            Persistence.Database oDatos;
            oDatos = new Persistence.Database();
            oDatos.conectar();
            oDatos.Ejecutar_Consulta("SELECT TipoDocumento FROM TiposDocumento WHERE idTiposDocumento = " + _persona.idTiposDocumento);
            edtTipoNumero.Text = oDatos.Tabla.Rows[0].ItemArray[0].ToString() + " N° " + _persona.NumeroDocumento.ToString();
            oDatos.Desconectar();
            oDatos = new Persistence.Database();
            oDatos.conectar();
            oDatos.Ejecutar_Consulta("SELECT RolPersona FROM RolesPersonas WHERE idRolesPersonas = " + _persona.idRolesPersonas);
            edtRol.Text = oDatos.Tabla.Rows[0].ItemArray[0].ToString();
            oDatos.Desconectar();
            MemoryStream mem = _persona.ImagenPersonaPorId(idPersonas);
            PbxImagen.Image = Image.FromStream(mem);

             _ingresos.getIngreso(idIngresos);
            edtLote.Text = _ingresos.Lote;
            edtTiempoPersonal.Text = _ingresos.TiempoPersonal.ToString();
            edtVehiculo.Text = _ingresos.Vehiculo;
            edtPertenecias.Text = _ingresos.Pertenencias;
        } 
        


        private void btnCancelarIngreso_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIngresos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bioSoftDataSet2.TiposDocumento' table. You can move, or remove it, as needed.
            this.tiposDocumentoTableAdapter.Fill(this.bioSoftDataSet2.TiposDocumento);
        }
    }
}
