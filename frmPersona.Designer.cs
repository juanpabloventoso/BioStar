namespace BioStarCSharp
{
    partial class frmPersona
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.qPersonasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bioSoftDataSet6 = new BioStarCSharp.BioSoftDataSet6();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImagen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.colDedos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaAlta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaBaja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaNacimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCelular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasculino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvitado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAseguradora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRolPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVencimientoAseguradora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSexo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTiempoVisita = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.qPersonasTableAdapter = new BioStarCSharp.BioSoftDataSet6TableAdapters.qPersonasTableAdapter();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qPersonasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bioSoftDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.qPersonasBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.LookAndFeel.SkinName = "Blue";
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1047, 472);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // qPersonasBindingSource
            // 
            this.qPersonasBindingSource.DataMember = "qPersonas";
            this.qPersonasBindingSource.DataSource = this.bioSoftDataSet6;
            // 
            // bioSoftDataSet6
            // 
            this.bioSoftDataSet6.DataSetName = "BioSoftDataSet6";
            this.bioSoftDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colApellido,
            this.colNombre,
            this.colNumeroDocumento,
            this.colActivo,
            this.colImagen,
            this.colDedos,
            this.colFechaAlta,
            this.colFechaBaja,
            this.colFechaNacimiento,
            this.colCelular,
            this.colMasculino,
            this.colTipoDocumento,
            this.colInvitado,
            this.colAseguradora,
            this.colRolPersona,
            this.colVencimientoAseguradora,
            this.colSexo,
            this.colTiempoVisita});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.RowHeight = 48;
            // 
            // colApellido
            // 
            this.colApellido.Caption = "Apellido";
            this.colApellido.FieldName = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.Visible = true;
            this.colApellido.VisibleIndex = 0;
            this.colApellido.Width = 59;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Nombre";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            this.colNombre.Width = 59;
            // 
            // colNumeroDocumento
            // 
            this.colNumeroDocumento.Caption = "NumeroDocumento";
            this.colNumeroDocumento.FieldName = "NumeroDocumento";
            this.colNumeroDocumento.Name = "colNumeroDocumento";
            this.colNumeroDocumento.Visible = true;
            this.colNumeroDocumento.VisibleIndex = 2;
            this.colNumeroDocumento.Width = 59;
            // 
            // colActivo
            // 
            this.colActivo.Caption = "Activo";
            this.colActivo.FieldName = "Activo";
            this.colActivo.Name = "colActivo";
            this.colActivo.Visible = true;
            this.colActivo.VisibleIndex = 3;
            this.colActivo.Width = 54;
            // 
            // colImagen
            // 
            this.colImagen.Caption = "Imagen";
            this.colImagen.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colImagen.FieldName = "Imagen";
            this.colImagen.Name = "colImagen";
            this.colImagen.Visible = true;
            this.colImagen.VisibleIndex = 4;
            this.colImagen.Width = 48;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            // 
            // colDedos
            // 
            this.colDedos.Caption = "Dedos";
            this.colDedos.FieldName = "Dedos";
            this.colDedos.Name = "colDedos";
            this.colDedos.Visible = true;
            this.colDedos.VisibleIndex = 5;
            this.colDedos.Width = 58;
            // 
            // colFechaAlta
            // 
            this.colFechaAlta.Caption = "FechaAlta";
            this.colFechaAlta.FieldName = "FechaAlta";
            this.colFechaAlta.Name = "colFechaAlta";
            this.colFechaAlta.Visible = true;
            this.colFechaAlta.VisibleIndex = 6;
            this.colFechaAlta.Width = 58;
            // 
            // colFechaBaja
            // 
            this.colFechaBaja.Caption = "FechaBaja";
            this.colFechaBaja.FieldName = "FechaBaja";
            this.colFechaBaja.Name = "colFechaBaja";
            this.colFechaBaja.Visible = true;
            this.colFechaBaja.VisibleIndex = 7;
            this.colFechaBaja.Width = 58;
            // 
            // colFechaNacimiento
            // 
            this.colFechaNacimiento.Caption = "FechaNacimiento";
            this.colFechaNacimiento.FieldName = "FechaNacimiento";
            this.colFechaNacimiento.Name = "colFechaNacimiento";
            this.colFechaNacimiento.Visible = true;
            this.colFechaNacimiento.VisibleIndex = 8;
            this.colFechaNacimiento.Width = 58;
            // 
            // colCelular
            // 
            this.colCelular.Caption = "Celular";
            this.colCelular.FieldName = "Celular";
            this.colCelular.Name = "colCelular";
            this.colCelular.Visible = true;
            this.colCelular.VisibleIndex = 9;
            this.colCelular.Width = 58;
            // 
            // colMasculino
            // 
            this.colMasculino.Caption = "Masculino";
            this.colMasculino.FieldName = "Masculino";
            this.colMasculino.Name = "colMasculino";
            this.colMasculino.Visible = true;
            this.colMasculino.VisibleIndex = 10;
            this.colMasculino.Width = 58;
            // 
            // colTipoDocumento
            // 
            this.colTipoDocumento.Caption = "TipoDocumento";
            this.colTipoDocumento.FieldName = "TipoDocumento";
            this.colTipoDocumento.Name = "colTipoDocumento";
            this.colTipoDocumento.Visible = true;
            this.colTipoDocumento.VisibleIndex = 11;
            this.colTipoDocumento.Width = 58;
            // 
            // colInvitado
            // 
            this.colInvitado.Caption = "Invitado";
            this.colInvitado.FieldName = "Invitado";
            this.colInvitado.Name = "colInvitado";
            this.colInvitado.Visible = true;
            this.colInvitado.VisibleIndex = 12;
            this.colInvitado.Width = 67;
            // 
            // colAseguradora
            // 
            this.colAseguradora.Caption = "Aseguradora";
            this.colAseguradora.FieldName = "Aseguradora";
            this.colAseguradora.Name = "colAseguradora";
            this.colAseguradora.Visible = true;
            this.colAseguradora.VisibleIndex = 13;
            this.colAseguradora.Width = 55;
            // 
            // colRolPersona
            // 
            this.colRolPersona.Caption = "RolPersona";
            this.colRolPersona.FieldName = "RolPersona";
            this.colRolPersona.Name = "colRolPersona";
            this.colRolPersona.Visible = true;
            this.colRolPersona.VisibleIndex = 14;
            this.colRolPersona.Width = 55;
            // 
            // colVencimientoAseguradora
            // 
            this.colVencimientoAseguradora.Caption = "VencimientoAseguradora";
            this.colVencimientoAseguradora.FieldName = "VencimientoAseguradora";
            this.colVencimientoAseguradora.Name = "colVencimientoAseguradora";
            this.colVencimientoAseguradora.Visible = true;
            this.colVencimientoAseguradora.VisibleIndex = 15;
            this.colVencimientoAseguradora.Width = 55;
            // 
            // colSexo
            // 
            this.colSexo.Caption = "Sexo";
            this.colSexo.FieldName = "Sexo";
            this.colSexo.Name = "colSexo";
            this.colSexo.OptionsColumn.ReadOnly = true;
            this.colSexo.Visible = true;
            this.colSexo.VisibleIndex = 16;
            this.colSexo.Width = 55;
            // 
            // colTiempoVisita
            // 
            this.colTiempoVisita.Caption = "TiempoVisita";
            this.colTiempoVisita.FieldName = "TiempoVisita";
            this.colTiempoVisita.Name = "colTiempoVisita";
            this.colTiempoVisita.Visible = true;
            this.colTiempoVisita.VisibleIndex = 17;
            this.colTiempoVisita.Width = 83;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // qPersonasTableAdapter
            // 
            this.qPersonasTableAdapter.ClearBeforeFill = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(984, 501);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.Location = new System.Drawing.Point(891, 501);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarUsuario.TabIndex = 12;
            this.btnGuardarUsuario.Text = "Modificar";
            this.btnGuardarUsuario.UseVisualStyleBackColor = true;
            this.btnGuardarUsuario.Click += new System.EventHandler(this.btnGuardarUsuario_Click);
            // 
            // frmPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 536);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarUsuario);
            this.Controls.Add(this.gridControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPersona";
            this.Text = "frmPersona";
            this.Load += new System.EventHandler(this.frmPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qPersonasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bioSoftDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BioSoftDataSet6 bioSoftDataSet6;
        private System.Windows.Forms.BindingSource qPersonasBindingSource;
        private BioStarCSharp.BioSoftDataSet6TableAdapters.qPersonasTableAdapter qPersonasTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colApellido;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colActivo;
        private DevExpress.XtraGrid.Columns.GridColumn colImagen;
        private DevExpress.XtraGrid.Columns.GridColumn colDedos;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaAlta;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaBaja;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaNacimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colCelular;
        private DevExpress.XtraGrid.Columns.GridColumn colMasculino;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colInvitado;
        private DevExpress.XtraGrid.Columns.GridColumn colAseguradora;
        private DevExpress.XtraGrid.Columns.GridColumn colRolPersona;
        private DevExpress.XtraGrid.Columns.GridColumn colVencimientoAseguradora;
        private DevExpress.XtraGrid.Columns.GridColumn colSexo;
        private DevExpress.XtraGrid.Columns.GridColumn colTiempoVisita;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarUsuario;
    }
}