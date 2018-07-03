using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BioStarCSharp
{
    public partial class frmSplash : Form
    {

        BioSoft.BioStar _BioStar;

        public frmSplash()
        {
            InitializeComponent();
        }

        public void SetBioStar(BioSoft.BioStar BioStar)
        {
            _BioStar = BioStar;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void frmSplash_Shown(object sender, EventArgs e)
        {
            lblEstado.Text = "Obteniendo dispositivos. Por favor espere...";
            Application.DoEvents();
            _BioStar.LeerDispositivos();
            if (_BioStar.Dispositivos.Count > 0)
            {
                BioSoft.DispositivoBioStar Dispositivo = (BioSoft.DispositivoBioStar)_BioStar.Dispositivos[0];
                lblEstado.Text = "Conectando dispositivos BioStar...";
                Application.DoEvents();
                Dispositivo.Conectar();
                lblEstado.Text = "Leyendo usuarios...";
                Application.DoEvents();
                Dispositivo.LeerUsuarios();
            }
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
