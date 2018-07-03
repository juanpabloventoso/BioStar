using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using BioSoft;
using System.Windows.Forms;
using System.Collections;
using System.IO;


namespace BioStarCSharp
{
    public partial class frmAgregarPersona : Form
    {
        BioSoft.DispositivoBioStar _Dispositivo;
        persona _Persona;
        WebCam _Webcam;

        public frmAgregarPersona()
        {
            InitializeComponent();
            _Persona = new persona();
            _Webcam = new WebCam(10, PbxImagen);
        }

        private void frmAgregarPersona_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bioSoftDataSet5.qRolesPersonasAct' table. You can move, or remove it, as needed.
            this.qRolesPersonasActTableAdapter.Fill(this.bioSoftDataSet5.qRolesPersonasAct);
            // TODO: This line of code loads data into the 'bioSoftDataSet4.NivelesSeguridad' table. You can move, or remove it, as needed.
            this.nivelesSeguridadTableAdapter.Fill(this.bioSoftDataSet4.NivelesSeguridad);
            // TODO: This line of code loads data into the 'bioSoftDataSet3.TiposDocumento' table. You can move, or remove it, as needed.
            this.tiposDocumentoTableAdapter.Fill(this.bioSoftDataSet3.TiposDocumento);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Editar(BioSoft.DispositivoBioStar Dispositivo, int ID)
        {
            _Dispositivo = Dispositivo;
            Persistence.Database db = new Persistence.Database();
            db.conectar();
            System.IO.MemoryStream mem = db.Ejecutar_Consulta_Imagen("SELECT Imagen FROM Personas WHERE idPersonas = " + ID);
            PbxImage2.Image = Image.FromStream(mem);
            _Persona.getPersona(ID);
            edtApellido.Text = _Persona.Apellido;
            edtNombre.Text = _Persona.Nombre;
            cmbTipoDocumento.SelectedValue = _Persona.idTiposDocumento;
            edtDocumento.Text = _Persona.NumeroDocumento.ToString();
            edtCelular.Text = _Persona.Celular;
            edtFechaAlta.Value = _Persona.FechaAlta;
            chkNuncaExpira.Checked = false;
            if (_Persona.FechaAlta != null)
            edtFechaBaja.Value = _Persona.FechaBaja;
            edtFechaNacimiento.Value = _Persona.FechaNacimiento;
            if (_Persona.Masculino)
                rbSexo1.Checked = true;
            else rbSexo2.Checked = true;
            if (_Persona.Administrador)
                rbAdministrador.Checked = true;
            else rbUsuario.Checked = true;
            cmbNivelSeguridad.SelectedValue = _Persona.idNivelesSeguridad;
            cmbRolPersona.SelectedValue = _Persona.idRolesPersonas;
        }

        public void Agregar(BioSoft.DispositivoBioStar Dispositivo)
        {
            _Dispositivo = Dispositivo;
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            _Webcam.StopCaptura();
            GuardarDatosPersonales();
            int ID = _Persona.Alta();
            frmTomarHuella F = new frmTomarHuella();
            F.setValores(_Persona, _Dispositivo, chkNuncaExpira.Checked);
            F.ShowDialog();
            this.Close();
        }


        private void GuardarDatosPersonales()
        {
            _Persona.Apellido = edtApellido.Text;
            _Persona.Nombre = edtNombre.Text;
            _Persona.idTiposDocumento = int.Parse(cmbTipoDocumento.SelectedValue.ToString());
            if (edtDocumento.Text != "")
                _Persona.NumeroDocumento = int.Parse(edtDocumento.Text);
            _Persona.Activo = true;
            _Persona.Celular = edtCelular.Text;
            _Persona.FechaAlta = edtFechaAlta.Value;
            if (!chkNuncaExpira.Checked)
                _Persona.FechaBaja = edtFechaBaja.Value;
            _Persona.FechaNacimiento = edtFechaNacimiento.Value;
            if (rbSexo1.Checked)
                _Persona.Masculino = true;
            else _Persona.Masculino = false;
            _Persona.Imagen = Biosoft.imagen.Image2Bytes(this.PbxImage2.Image);
            if (!rbAdministrador.Checked)
                _Persona.Administrador = false;
            else _Persona.Administrador = true;
            _Persona.idNivelesSeguridad = int.Parse(cmbNivelSeguridad.SelectedValue.ToString());
            _Persona.idRolesPersonas = int.Parse(cmbRolPersona.SelectedValue.ToString());
            
        }

        private void btnTomarFoto_Click_1(object sender, EventArgs e)
        {
            PbxImage2.Image = PbxImagen.Image;
            _Persona.Imagen = Biosoft.imagen.Image2Bytes(this.PbxImage2.Image);
        }

        private void btnEncender_Click_1(object sender, EventArgs e)
        {
            _Webcam.Capturar(0);
        }
    }
}
