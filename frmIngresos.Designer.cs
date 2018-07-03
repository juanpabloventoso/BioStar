namespace BioStarCSharp
{
    partial class frmIngresos
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
            this.tiposDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bioSoftDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bioSoftDataSet2 = new BioStarCSharp.BioSoftDataSet2();
            this.brnAceptarIngreso = new System.Windows.Forms.Button();
            this.btnCancelarIngreso = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.edtLote = new System.Windows.Forms.TextBox();
            this.edtPertenecias = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.edtVehiculo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edtTiempoPersonal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edtRol = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.edtTipoNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.edtNombreApellido = new System.Windows.Forms.TextBox();
            this.PbxImagen = new System.Windows.Forms.PictureBox();
            this.tiposDocumentoTableAdapter = new BioStarCSharp.BioSoftDataSet2TableAdapters.TiposDocumentoTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bioSoftDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bioSoftDataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // tiposDocumentoBindingSource
            // 
            this.tiposDocumentoBindingSource.DataMember = "TiposDocumento";
            this.tiposDocumentoBindingSource.DataSource = this.bioSoftDataSet2BindingSource;
            // 
            // bioSoftDataSet2BindingSource
            // 
            this.bioSoftDataSet2BindingSource.DataSource = this.bioSoftDataSet2;
            this.bioSoftDataSet2BindingSource.Position = 0;
            // 
            // bioSoftDataSet2
            // 
            this.bioSoftDataSet2.DataSetName = "BioSoftDataSet2";
            this.bioSoftDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brnAceptarIngreso
            // 
            this.brnAceptarIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.brnAceptarIngreso.Location = new System.Drawing.Point(342, 327);
            this.brnAceptarIngreso.Name = "brnAceptarIngreso";
            this.brnAceptarIngreso.Size = new System.Drawing.Size(87, 27);
            this.brnAceptarIngreso.TabIndex = 75;
            this.brnAceptarIngreso.Text = "Aceptar";
            this.brnAceptarIngreso.UseVisualStyleBackColor = true;
            this.brnAceptarIngreso.Click += new System.EventHandler(this.brnAceptarIngreso_Click);
            // 
            // btnCancelarIngreso
            // 
            this.btnCancelarIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarIngreso.Location = new System.Drawing.Point(450, 327);
            this.btnCancelarIngreso.Name = "btnCancelarIngreso";
            this.btnCancelarIngreso.Size = new System.Drawing.Size(91, 27);
            this.btnCancelarIngreso.TabIndex = 76;
            this.btnCancelarIngreso.Text = "Cancelar";
            this.btnCancelarIngreso.UseVisualStyleBackColor = true;
            this.btnCancelarIngreso.Click += new System.EventHandler(this.btnCancelarIngreso_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.edtLote);
            this.panel1.Controls.Add(this.edtPertenecias);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.edtVehiculo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.edtTiempoPersonal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(23, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 160);
            this.panel1.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Lote:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edtLote
            // 
            this.edtLote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtLote.Location = new System.Drawing.Point(115, 16);
            this.edtLote.Name = "edtLote";
            this.edtLote.Size = new System.Drawing.Size(173, 21);
            this.edtLote.TabIndex = 71;
            // 
            // edtPertenecias
            // 
            this.edtPertenecias.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtPertenecias.Location = new System.Drawing.Point(114, 90);
            this.edtPertenecias.Multiline = true;
            this.edtPertenecias.Name = "edtPertenecias";
            this.edtPertenecias.Size = new System.Drawing.Size(370, 48);
            this.edtPertenecias.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "Pertenencias:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edtVehiculo
            // 
            this.edtVehiculo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtVehiculo.Location = new System.Drawing.Point(376, 53);
            this.edtVehiculo.Name = "edtVehiculo";
            this.edtVehiculo.Size = new System.Drawing.Size(108, 21);
            this.edtVehiculo.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Patente del vehículo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edtTiempoPersonal
            // 
            this.edtTiempoPersonal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtTiempoPersonal.Location = new System.Drawing.Point(114, 51);
            this.edtTiempoPersonal.Name = "edtTiempoPersonal";
            this.edtTiempoPersonal.Size = new System.Drawing.Size(46, 21);
            this.edtTiempoPersonal.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Tiempo personal:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "Rol:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edtRol
            // 
            this.edtRol.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtRol.Location = new System.Drawing.Point(140, 91);
            this.edtRol.Name = "edtRol";
            this.edtRol.ReadOnly = true;
            this.edtRol.Size = new System.Drawing.Size(159, 21);
            this.edtRol.TabIndex = 82;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 81;
            this.label9.Text = "Documento:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edtTipoNumero
            // 
            this.edtTipoNumero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtTipoNumero.Location = new System.Drawing.Point(140, 64);
            this.edtTipoNumero.Name = "edtTipoNumero";
            this.edtTipoNumero.ReadOnly = true;
            this.edtTipoNumero.Size = new System.Drawing.Size(159, 21);
            this.edtTipoNumero.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 79;
            this.label7.Text = "Apellido y nombres:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edtNombreApellido
            // 
            this.edtNombreApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtNombreApellido.Location = new System.Drawing.Point(140, 36);
            this.edtNombreApellido.Name = "edtNombreApellido";
            this.edtNombreApellido.ReadOnly = true;
            this.edtNombreApellido.Size = new System.Drawing.Size(247, 21);
            this.edtNombreApellido.TabIndex = 78;
            // 
            // PbxImagen
            // 
            this.PbxImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxImagen.InitialImage = null;
            this.PbxImagen.Location = new System.Drawing.Point(410, 36);
            this.PbxImagen.Name = "PbxImagen";
            this.PbxImagen.Size = new System.Drawing.Size(81, 76);
            this.PbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxImagen.TabIndex = 77;
            this.PbxImagen.TabStop = false;
            // 
            // tiposDocumentoTableAdapter
            // 
            this.tiposDocumentoTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 85;
            this.label4.Text = "Datos del ingreso";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 13);
            this.label10.TabIndex = 86;
            this.label10.Text = "Persona que ingresa";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 369);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtRol);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.edtTipoNumero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.edtNombreApellido);
            this.Controls.Add(this.PbxImagen);
            this.Controls.Add(this.btnCancelarIngreso);
            this.Controls.Add(this.brnAceptarIngreso);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmIngresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles del ingreso";
            this.Load += new System.EventHandler(this.frmIngresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tiposDocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bioSoftDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bioSoftDataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button brnAceptarIngreso;
        private System.Windows.Forms.Button btnCancelarIngreso;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtLote;
        private System.Windows.Forms.TextBox edtPertenecias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edtVehiculo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edtTiempoPersonal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtRol;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox edtTipoNumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox edtNombreApellido;
        private System.Windows.Forms.PictureBox PbxImagen;
        private System.Windows.Forms.BindingSource bioSoftDataSet2BindingSource;
        private BioSoftDataSet2 bioSoftDataSet2;
        private System.Windows.Forms.BindingSource tiposDocumentoBindingSource;
        private BioStarCSharp.BioSoftDataSet2TableAdapters.TiposDocumentoTableAdapter tiposDocumentoTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        
    }
}