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
    public partial class frmPersona : Form
    {
        DispositivoBioStar _Dispositivo;

        public frmPersona()
        {
            InitializeComponent();
        }

        private void frmPersona_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bioSoftDataSet6.qPersonas' table. You can move, or remove it, as needed.
            this.qPersonasTableAdapter.Fill(this.bioSoftDataSet6.qPersonas);
        }

        private void setValores(DispositivoBioStar Dispositivo)
        {
            _Dispositivo = Dispositivo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            frmAgregarPersona F = new frmAgregarPersona();
            F.Editar(_Dispositivo, int.Parse(gridView1.GetFocusedRowCellValue("idPersonas").ToString()));
            F.ShowDialog();
        }
    }
}
