namespace BioStarCSharp
{
    partial class frmAgregarPersona
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
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.bioSoftDataSet3 = new BioStarCSharp.dsTiposDocumento();
            this.tiposDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiposDocumentoTableAdapter = new BioStarCSharp.BioSoftDataSet3TableAdapters.TiposDocumentoTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbRolPersona = new System.Windows.Forms.ComboBox();
            this.qRolesPersonasActBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bioSoftDataSet5 = new BioStarCSharp.BioSoftDataSet5();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbUsuario = new System.Windows.Forms.RadioButton();
            this.rbAdministrador = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbSexo1 = new System.Windows.Forms.RadioButton();
            this.rbSexo2 = new System.Windows.Forms.RadioButton();
            this.cmbNivelSeguridad = new System.Windows.Forms.ComboBox();
            this.nivelesSeguridadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bioSoftDataSet4 = new BioStarCSharp.BioSoftDataSet4();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.edtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.chkNuncaExpira = new System.Windows.Forms.CheckBox();
            this.edtFechaBaja = new System.Windows.Forms.DateTimePicker();
            this.edtFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.edtDocumento = new System.Windows.Forms.TextBox();
            this.edtCelular = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edtApellido = new System.Windows.Forms.TextBox();
            this.edtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PbxImage2 = new System.Windows.Forms.PictureBox();
            this.PbxImagen = new System.Windows.Forms.PictureBox();
            this.btnTomarFoto = new System.Windows.Forms.Button();
            this.btnEncender = new System.Windows.Forms.Button();
            this.nivelesSeguridadTableAdapter = new BioStarCSharp.BioSoftDataSet4TableAdapters.NivelesSeguridadTableAdapter();
            this.qRolesPersonasActTableAdapter = new BioStarCSharp.BioSoftDataSet5TableAdapters.qRolesPersonasActTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bioSoftDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDocumentoBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qRolesPersonasActBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bioSoftDataSet5)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nivelesSeguridadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bioSoftDataSet4)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.Location = new System.Drawing.Point(598, 402);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarUsuario.TabIndex = 5;
            this.btnGuardarUsuario.Text = "Guardar";
            this.btnGuardarUsuario.UseVisualStyleBackColor = true;
            this.btnGuardarUsuario.Click += new System.EventHandler(this.btnGuardarUsuario_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(691, 402);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // bioSoftDataSet3
            // 
            this.bioSoftDataSet3.DataSetName = "BioSoftDataSet3";
            this.bioSoftDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tiposDocumentoBindingSource
            // 
            this.tiposDocumentoBindingSource.DataMember = "TiposDocumento";
            this.tiposDocumentoBindingSource.DataSource = this.bioSoftDataSet3;
            // 
            // tiposDocumentoTableAdapter
            // 
            this.tiposDocumentoTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(758, 373);
            this.tabControl1.TabIndex = 37;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbRolPersona);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.cmbNivelSeguridad);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.edtFechaNacimiento);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.chkNuncaExpira);
            this.tabPage1.Controls.Add(this.edtFechaBaja);
            this.tabPage1.Controls.Add(this.edtFechaAlta);
            this.tabPage1.Controls.Add(this.cmbTipoDocumento);
            this.tabPage1.Controls.Add(this.edtDocumento);
            this.tabPage1.Controls.Add(this.edtCelular);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.edtApellido);
            this.tabPage1.Controls.Add(this.edtNombre);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(750, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos personales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbRolPersona
            // 
            this.cmbRolPersona.DataSource = this.qRolesPersonasActBindingSource;
            this.cmbRolPersona.DisplayMember = "RolPersona";
            this.cmbRolPersona.FormattingEnabled = true;
            this.cmbRolPersona.Location = new System.Drawing.Point(134, 201);
            this.cmbRolPersona.Name = "cmbRolPersona";
            this.cmbRolPersona.Size = new System.Drawing.Size(186, 21);
            this.cmbRolPersona.TabIndex = 61;
            this.cmbRolPersona.ValueMember = "idRolesPersonas";
            // 
            // qRolesPersonasActBindingSource
            // 
            this.qRolesPersonasActBindingSource.DataMember = "qRolesPersonasAct";
            this.qRolesPersonasActBindingSource.DataSource = this.bioSoftDataSet5;
            // 
            // bioSoftDataSet5
            // 
            this.bioSoftDataSet5.DataSetName = "BioSoftDataSet5";
            this.bioSoftDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(104, 204);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 13);
            this.label16.TabIndex = 60;
            this.label16.Text = "Rol:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbUsuario);
            this.panel2.Controls.Add(this.rbAdministrador);
            this.panel2.Location = new System.Drawing.Point(134, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 26);
            this.panel2.TabIndex = 59;
            // 
            // rbUsuario
            // 
            this.rbUsuario.AutoSize = true;
            this.rbUsuario.Checked = true;
            this.rbUsuario.Location = new System.Drawing.Point(3, 3);
            this.rbUsuario.Name = "rbUsuario";
            this.rbUsuario.Size = new System.Drawing.Size(61, 17);
            this.rbUsuario.TabIndex = 56;
            this.rbUsuario.TabStop = true;
            this.rbUsuario.Text = "Usuario";
            this.rbUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbUsuario.UseVisualStyleBackColor = true;
            // 
            // rbAdministrador
            // 
            this.rbAdministrador.AutoSize = true;
            this.rbAdministrador.Location = new System.Drawing.Point(68, 3);
            this.rbAdministrador.Name = "rbAdministrador";
            this.rbAdministrador.Size = new System.Drawing.Size(91, 17);
            this.rbAdministrador.TabIndex = 57;
            this.rbAdministrador.Text = "Administrador";
            this.rbAdministrador.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbSexo1);
            this.panel1.Controls.Add(this.rbSexo2);
            this.panel1.Location = new System.Drawing.Point(424, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 27);
            this.panel1.TabIndex = 58;
            // 
            // rbSexo1
            // 
            this.rbSexo1.AutoSize = true;
            this.rbSexo1.Checked = true;
            this.rbSexo1.Location = new System.Drawing.Point(5, 3);
            this.rbSexo1.Name = "rbSexo1";
            this.rbSexo1.Size = new System.Drawing.Size(71, 17);
            this.rbSexo1.TabIndex = 45;
            this.rbSexo1.TabStop = true;
            this.rbSexo1.Text = "Masculino";
            this.rbSexo1.UseVisualStyleBackColor = true;
            // 
            // rbSexo2
            // 
            this.rbSexo2.AutoSize = true;
            this.rbSexo2.Location = new System.Drawing.Point(82, 3);
            this.rbSexo2.Name = "rbSexo2";
            this.rbSexo2.Size = new System.Drawing.Size(71, 17);
            this.rbSexo2.TabIndex = 46;
            this.rbSexo2.Text = "Femenino";
            this.rbSexo2.UseVisualStyleBackColor = true;
            // 
            // cmbNivelSeguridad
            // 
            this.cmbNivelSeguridad.DataSource = this.nivelesSeguridadBindingSource;
            this.cmbNivelSeguridad.DisplayMember = "NivelSeguridad";
            this.cmbNivelSeguridad.FormattingEnabled = true;
            this.cmbNivelSeguridad.Location = new System.Drawing.Point(426, 160);
            this.cmbNivelSeguridad.Name = "cmbNivelSeguridad";
            this.cmbNivelSeguridad.Size = new System.Drawing.Size(186, 21);
            this.cmbNivelSeguridad.TabIndex = 55;
            this.cmbNivelSeguridad.ValueMember = "idNivelesSeguridad";
            // 
            // nivelesSeguridadBindingSource
            // 
            this.nivelesSeguridadBindingSource.DataMember = "NivelesSeguridad";
            this.nivelesSeguridadBindingSource.DataSource = this.bioSoftDataSet4;
            // 
            // bioSoftDataSet4
            // 
            this.bioSoftDataSet4.DataSetName = "BioSoftDataSet4";
            this.bioSoftDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(317, 162);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 13);
            this.label14.TabIndex = 54;
            this.label14.Text = "Nivel de seguridad:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 163);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 13);
            this.label15.TabIndex = 52;
            this.label15.Text = "Rol de administración:";
            // 
            // edtFechaNacimiento
            // 
            this.edtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.edtFechaNacimiento.Location = new System.Drawing.Point(139, 125);
            this.edtFechaNacimiento.Name = "edtFechaNacimiento";
            this.edtFechaNacimiento.Size = new System.Drawing.Size(108, 21);
            this.edtFechaNacimiento.TabIndex = 51;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 13);
            this.label13.TabIndex = 50;
            this.label13.Text = "Fecha de nacimiento:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkNuncaExpira
            // 
            this.chkNuncaExpira.AutoSize = true;
            this.chkNuncaExpira.Checked = true;
            this.chkNuncaExpira.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNuncaExpira.Location = new System.Drawing.Point(554, 57);
            this.chkNuncaExpira.Name = "chkNuncaExpira";
            this.chkNuncaExpira.Size = new System.Drawing.Size(89, 17);
            this.chkNuncaExpira.TabIndex = 49;
            this.chkNuncaExpira.Text = "Nunca expira";
            this.chkNuncaExpira.UseVisualStyleBackColor = true;
            // 
            // edtFechaBaja
            // 
            this.edtFechaBaja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.edtFechaBaja.Location = new System.Drawing.Point(426, 55);
            this.edtFechaBaja.Name = "edtFechaBaja";
            this.edtFechaBaja.Size = new System.Drawing.Size(111, 21);
            this.edtFechaBaja.TabIndex = 48;
            // 
            // edtFechaAlta
            // 
            this.edtFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.edtFechaAlta.Location = new System.Drawing.Point(138, 55);
            this.edtFechaAlta.Name = "edtFechaAlta";
            this.edtFechaAlta.Size = new System.Drawing.Size(109, 21);
            this.edtFechaAlta.TabIndex = 47;
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DataSource = this.tiposDocumentoBindingSource;
            this.cmbTipoDocumento.DisplayMember = "TipoDocumento";
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(138, 92);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(59, 21);
            this.cmbTipoDocumento.TabIndex = 44;
            this.cmbTipoDocumento.ValueMember = "idTiposDocumento";
            // 
            // edtDocumento
            // 
            this.edtDocumento.Location = new System.Drawing.Point(203, 92);
            this.edtDocumento.Name = "edtDocumento";
            this.edtDocumento.Size = new System.Drawing.Size(121, 21);
            this.edtDocumento.TabIndex = 43;
            // 
            // edtCelular
            // 
            this.edtCelular.Location = new System.Drawing.Point(426, 125);
            this.edtCelular.Name = "edtCelular";
            this.edtCelular.Size = new System.Drawing.Size(186, 21);
            this.edtCelular.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Celular:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Sexo:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Documento:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Expiración:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Fecha de alta:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Apellido:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edtApellido
            // 
            this.edtApellido.Location = new System.Drawing.Point(426, 16);
            this.edtApellido.Name = "edtApellido";
            this.edtApellido.Size = new System.Drawing.Size(186, 21);
            this.edtApellido.TabIndex = 35;
            // 
            // edtNombre
            // 
            this.edtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtNombre.Location = new System.Drawing.Point(139, 16);
            this.edtNombre.Name = "edtNombre";
            this.edtNombre.Size = new System.Drawing.Size(171, 21);
            this.edtNombre.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nombres:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.PbxImage2);
            this.tabPage3.Controls.Add(this.PbxImagen);
            this.tabPage3.Controls.Add(this.btnTomarFoto);
            this.tabPage3.Controls.Add(this.btnEncender);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(750, 347);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Foto";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(379, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Foto de la persona:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Cámara:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PbxImage2
            // 
            this.PbxImage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxImage2.Image = global::BioStarCSharp.Properties.Resources.SiluetaH;
            this.PbxImage2.InitialImage = global::BioStarCSharp.Properties.Resources._17_05_05_1554;
            this.PbxImage2.Location = new System.Drawing.Point(382, 32);
            this.PbxImage2.Name = "PbxImage2";
            this.PbxImage2.Size = new System.Drawing.Size(346, 267);
            this.PbxImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxImage2.TabIndex = 40;
            this.PbxImage2.TabStop = false;
            // 
            // PbxImagen
            // 
            this.PbxImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxImagen.InitialImage = null;
            this.PbxImagen.Location = new System.Drawing.Point(21, 32);
            this.PbxImagen.Name = "PbxImagen";
            this.PbxImagen.Size = new System.Drawing.Size(346, 267);
            this.PbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxImagen.TabIndex = 39;
            this.PbxImagen.TabStop = false;
            // 
            // btnTomarFoto
            // 
            this.btnTomarFoto.Location = new System.Drawing.Point(382, 305);
            this.btnTomarFoto.Name = "btnTomarFoto";
            this.btnTomarFoto.Size = new System.Drawing.Size(108, 23);
            this.btnTomarFoto.TabIndex = 38;
            this.btnTomarFoto.Text = "Tomar foto ^^";
            this.btnTomarFoto.UseVisualStyleBackColor = true;
            this.btnTomarFoto.Click += new System.EventHandler(this.btnTomarFoto_Click_1);
            // 
            // btnEncender
            // 
            this.btnEncender.Location = new System.Drawing.Point(21, 305);
            this.btnEncender.Name = "btnEncender";
            this.btnEncender.Size = new System.Drawing.Size(136, 23);
            this.btnEncender.TabIndex = 37;
            this.btnEncender.Text = "Iniciar Webcam ^^";
            this.btnEncender.UseVisualStyleBackColor = true;
            this.btnEncender.Click += new System.EventHandler(this.btnEncender_Click_1);
            // 
            // nivelesSeguridadTableAdapter
            // 
            this.nivelesSeguridadTableAdapter.ClearBeforeFill = true;
            // 
            // qRolesPersonasActTableAdapter
            // 
            this.qRolesPersonasActTableAdapter.ClearBeforeFill = true;
            // 
            // frmAgregarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 437);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarUsuario);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarPersona";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles de la persona";
            this.Load += new System.EventHandler(this.frmAgregarPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bioSoftDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDocumentoBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qRolesPersonasActBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bioSoftDataSet5)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nivelesSeguridadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bioSoftDataSet4)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private dsTiposDocumento bioSoftDataSet3;
        private System.Windows.Forms.BindingSource tiposDocumentoBindingSource;
        private BioStarCSharp.BioSoftDataSet3TableAdapters.TiposDocumentoTableAdapter tiposDocumentoTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker edtFechaBaja;
        private System.Windows.Forms.DateTimePicker edtFechaAlta;
        private System.Windows.Forms.RadioButton rbSexo2;
        private System.Windows.Forms.RadioButton rbSexo1;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.TextBox edtDocumento;
        private System.Windows.Forms.TextBox edtCelular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtApellido;
        private System.Windows.Forms.TextBox edtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox PbxImage2;
        private System.Windows.Forms.PictureBox PbxImagen;
        private System.Windows.Forms.Button btnTomarFoto;
        private System.Windows.Forms.Button btnEncender;
        private System.Windows.Forms.CheckBox chkNuncaExpira;
        private System.Windows.Forms.DateTimePicker edtFechaNacimiento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbNivelSeguridad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton rbAdministrador;
        private System.Windows.Forms.RadioButton rbUsuario;
        private BioSoftDataSet4 bioSoftDataSet4;
        private System.Windows.Forms.BindingSource nivelesSeguridadBindingSource;
        private BioStarCSharp.BioSoftDataSet4TableAdapters.NivelesSeguridadTableAdapter nivelesSeguridadTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbRolPersona;
        private System.Windows.Forms.Label label16;
        private BioSoftDataSet5 bioSoftDataSet5;
        private System.Windows.Forms.BindingSource qRolesPersonasActBindingSource;
        private BioStarCSharp.BioSoftDataSet5TableAdapters.qRolesPersonasActTableAdapter qRolesPersonasActTableAdapter;
    }
}