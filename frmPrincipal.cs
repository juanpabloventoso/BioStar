using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BioSoft;

namespace BioStarCSharp
{
    public partial class frmPrincipal : Form
    {
        private BioSoft.BioStar _BioStar;

        public frmPrincipal()
        {
            InitializeComponent();
            _BioStar = new BioSoft.BioStar();
        }

        public BioSoft.BioStar BioStar { get { return _BioStar; } }
       
        private void Principal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bioSoftDataSet2.qIngresos' table. You can move, or remove it, as needed.
            this.qIngresosTableAdapter.Fill(this.bioSoftDataSet2.qIngresos);
            // TODO: This line of code loads data into the 'bioSoftDataSet1.Personas' table. You can move, or remove it, as needed.
            this.personasTableAdapter.Fill(this.bioSoftDataSet1.Personas);
        }

        private void btnAgregarPersona_Click(object sender, EventArgs e)
        {
        }

        private void frmPrincipal_Shown(object sender, EventArgs e)
        {
            frmSplash F = new frmSplash();
            F.SetBioStar(_BioStar);
            F.ShowDialog();
            tmrGrilla.Enabled = true;
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmAgregarPersona F = new frmAgregarPersona();
            F.Agregar((BioSoft.DispositivoBioStar)_BioStar.Dispositivos[0]);
            F.ShowDialog();
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmPersona F = new frmPersona();
            F.ShowDialog();
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmIngresos F = new frmIngresos();
            F.setDispositivo((BioSoft.DispositivoBioStar)_BioStar.Dispositivos[0]);
            F.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int idPersonas = int.Parse(gridView1.GetFocusedRowCellValue("idPersonas").ToString());
            int idIngresos = int.Parse(gridView1.GetFocusedRowCellValue("idIngresos").ToString());
            frmIngresos F = new frmIngresos();
            F.modificarIngreso(idPersonas, idIngresos);
            F.ShowDialog();
        }


        private void AgregarIngresos()
        {
            DispositivoBioStar Dispositivo = (DispositivoBioStar)_BioStar.Dispositivos[0];
            Dispositivo.LeerLogIngresosEgresosExitosos();

            Persistence.Database oDatos = new Persistence.Database();
            oDatos.conectar();
            oDatos.Ejecutar_Consulta("SELECT UltimaFechaLog FROM Configuracion");
            DateTime UltimoLog = new DateTime(1970, 1, 1);
            if (oDatos.Tabla.Rows.Count > 0)
                UltimoLog = DateTime.Parse(oDatos.Tabla.Rows[0].ItemArray[0].ToString());
            oDatos.Desconectar();


            DateTime UltimoLogNuevo = new DateTime(1970, 1, 1);
            oDatos.conectar();
            foreach (LogBioStar Registro in Dispositivo.Log)
            {
                if ((Registro.FechaHora > UltimoLog) && (Registro.EventoTNA == 0))
                {
                    oDatos.Ejecutar_Sentencia("INSERT INTO Ingresos (idPersonas, Activo, FechaIngreso, idUbicacionesIngreso, idUbicacionesEgreso) VALUES (" +
                    Registro.UsuarioID + ", 'True', " + BioSoft.Funciones.FechaASQL(Registro.FechaHora) + "," + 1 + "," + 1 + ")");
                    if (Registro.FechaHora > UltimoLogNuevo)
                        UltimoLogNuevo = Registro.FechaHora;
                }
            }
            oDatos.Desconectar();


            if (UltimoLogNuevo.Year > 1970)
            {
                oDatos.conectar();
                oDatos.Ejecutar_Sentencia("UPDATE Configuracion SET UltimaFechaLog = " + BioSoft.Funciones.FechaASQL(UltimoLogNuevo));
                oDatos.Desconectar();
            }
        
        }

        private void AgregarEgresos()
        {
            // AQUELLOS EGRESOS NO TOMADOS POR EL SISTEMA, BUSCAR EL INGRESO Y METER LA FECHA DE EGRESO Y BORRAR DE LA GRILLA (Activo = false)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tmrGrilla_Tick(sender, e);
        }

        private void tmrGrilla_Tick(object sender, EventArgs e)
        {
            AgregarIngresos();
            AgregarEgresos();
            qIngresosTableAdapter.Fill(this.bioSoftDataSet2.qIngresos);
            grdPersonas.RefreshDataSource();
        }
    }
}

