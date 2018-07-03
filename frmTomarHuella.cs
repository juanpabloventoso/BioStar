using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BioSoft;


namespace BioStarCSharp
{
    public partial class frmTomarHuella : Form
    {
        private persona _Persona;
        private DispositivoBioStar _Dispositivo;
        private bool _NuncaExpira;
        public frmTomarHuella()
        {
            InitializeComponent();
        }


        public void setValores(persona Persona, DispositivoBioStar Dispositivo, bool NuncaExpira)
        {
            _Persona = Persona;
            _Dispositivo = Dispositivo;
            _NuncaExpira = NuncaExpira;
        }

        public void CallbackHuellas(int ADedo, int AHuella)
        {
            label1.Text = "Leyendo dedo " + ADedo + " (lectura " + AHuella + ")...";
            Application.DoEvents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            edtDedos.Enabled = false;
            label1.Text = "Agregando usuario al dispositivo...";
            label1.Visible = true;
            Application.DoEvents();

            // Agregar el usuario al dispositivo
            BioSoft.DispositivoBioStar.HuellaCallback Funcion = new BioSoft.DispositivoBioStar.HuellaCallback(this.CallbackHuellas);
            DateTime FechaBaja = _Persona.FechaBaja;
            if (_NuncaExpira) FechaBaja = FechaBaja.AddYears(10);
            _Dispositivo.AgregarUsuario(_Persona.idPersonas, _Persona.Nombre, int.Parse(edtDedos.Text),
                false, 1, 0, 0, _Persona.FechaAlta.Ticks, FechaBaja.Ticks, false, false, 0, "FFFFFFFF", false, Funcion);
            UsuarioBioStar Usuario = (UsuarioBioStar)_Dispositivo.UsuarioPorID(_Persona.idPersonas);

            // Actualizar al usuario en la base de datos
            label1.Text = "Guardando en la base de datos...";
            Application.DoEvents();
            _Persona.Dedos = int.Parse(edtDedos.Text);
            _Persona.Dedo1Checksum = int.Parse(Usuario.Dedo1Checksum.ToString());
            _Persona.Dedo1Huella = Usuario.Dedo1Huella;
            label11.Visible = true;
            edtDedo1Checksum.Visible = true;
            edtDedo1Checksum.Text = "Ingreso correcto (" + Usuario.Dedo1Checksum.ToString() + ")";
            if (_Persona.Dedos > 1)
            {
                _Persona.Dedo2Checksum = int.Parse(Usuario.Dedo2Checksum.ToString());
                _Persona.Dedo2Huella = Usuario.Dedo2Huella;
                label12.Visible = true;
                edtDedo2Checksum.Visible = true;
                edtDedo2Checksum.Text = "Ingreso correcto (" + Usuario.Dedo2Checksum.ToString() + ")";
            }
            _Persona.Modificacion();
            label1.Text = "Proceso finalizado.";
            Application.DoEvents();
            btnAceptar.Visible = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
